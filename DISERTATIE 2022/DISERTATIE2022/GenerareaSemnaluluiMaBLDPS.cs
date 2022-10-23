using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.WindowsForms;

namespace DISERTATIE2022
{
    public partial class GenerareaSemnaluluiMaBLDPS : Form
    {
        double fc, V0, gm,wc;
        string g;
        public GenerareaSemnaluluiMaBLDPS()
        {
            InitializeComponent();
        }


        private void Calculeaza_Click(object sender, EventArgs e)
        {
            fc = Convert.ToDouble(textfc.Text);
            gm = Convert.ToDouble(textgm.Text);
            V0 = Convert.ToDouble(textV0.Text);

            wc = 2 * 3.14 * fc;

            textwc.Text = wc.ToString();
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            ModulatiaAM ob = new ModulatiaAM();
            ob.Show();
        }

       

        private void SemnalulModulator_Click(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0, 0);
            pv.Size = new Size(700, 250);
            panel3.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Modulator" };

            Func<double, double> fs1 = (x) => gm * Math.Sin(x);

            pv.Model.Series.Add(new FunctionSeries(fs1, gm, fc, 0.001));
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

        private void SemnalulPurtator_Click(object sender, EventArgs e)
        {
            
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0, 250);
            pv.Size = new Size(700, 250);
            panel3.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Purtator" };

            Func<double, double> fs2 = (x) => V0 * Math.Cos(x);

            pv.Model.Series.Add(new FunctionSeries(fs2, V0, fc, 0.001));
        }

        private void SemnalulModulat_Click(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0, 490);
            pv.Size = new Size(700, 250);
            panel3.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Modulat" };

            Func<double, double> fs3 = (x) => gm * Math.Sin(x) * Math.Cos(x);

            pv.Model.Series.Add(new FunctionSeries(fs3, gm, fc, 0.001));
        }



    }
}
