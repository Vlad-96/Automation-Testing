using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace DISERTATIE2022
{
    public partial class Demodularea_Necoerenta : Form
    {
        double gc,gm,m, fc, ηe, wc;
        string g;

        private void Calculeaza_Click(object sender, EventArgs e)
        {
            gc = Convert.ToDouble(textgc.Text);
            gm = Convert.ToDouble(textgm.Text);
            fc = Convert.ToDouble(textfc.Text);
            ηe = Convert.ToDouble(textηe.Text);

            wc = 2 * 3.14 * fc;
            m = gm / gc;

            textwc.Text = wc.ToString();
            textm.Text=m.ToString();    

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            DemodulatiaInAmplitudine ob = new DemodulatiaInAmplitudine();
            ob.Show();
        }

        private void Capture_Click(object sender, EventArgs e)
        {
            g = Convert.ToString(textg.Text);
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@g);
            }
        }

       

        public Demodularea_Necoerenta()
        {
            InitializeComponent();
        }

        private void SemnalulModulat_Click(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Size = new Size(700, 250);
            p1.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Modulat" };

            Func<double, double> fs1 = (x) =>  gc * (1 + m * Math.Sin(x)) * Math.Cos(wc*x);

            pv.Model.Series.Add(new FunctionSeries(fs1, gc, fc, 0.0001));
        }

        private void SemnalulExtrascuDA_Click(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Size = new Size(700, 250);
            p2.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Extras cu ajuorul Detectorului de Anvelopa" };

        
            Func<double, double> fs2 = (x) => gc * ηe+gc * ηe * m * Math.Sin(x);

            pv.Model.Series.Add(new FunctionSeries(fs2, gc, fc, 0.0001));

        }

        private void SemnaluldupaFiltrareaTS_Click(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Size = new Size(700, 250);
            p3.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Demodulat dupa Filtrarea TS" };


            Func<double, double> fs3 = (x) => gc * ηe * m * Math.Sin(x);

            pv.Model.Series.Add(new FunctionSeries(fs3, gc, fc, 0.0001));
        }

       
    }
}
