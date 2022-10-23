using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace DISERTATIE2022
{
    public partial class GenerareaSemnaluluiMF : Form
    {
        double Ap, Am, fp, fm, Δω, wp, wm, B, Kf;
        string g;


        public GenerareaSemnaluluiMF()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            ModulatiaInFrecventa ob = new ModulatiaInFrecventa();
            ob.Show();
        }

        private void Calculeaza_Click(object sender, EventArgs e)
        {
            Ap = Convert.ToDouble(textAp.Text);
            Am = Convert.ToDouble(textAm.Text);
            fp = Convert.ToDouble(textfp.Text);
            fm = Convert.ToDouble(textfm.Text);
            Kf = Convert.ToDouble(textKf.Text);


            wm = 2 * 3.14 * fm;
            wp = 2 * 3.14 * fp;
            B = Δω / wm;
            Δω = Am * Kf;

            textΔω.Text = Δω.ToString();
            textwp.Text = wp.ToString();
            textwm.Text = wm.ToString();
            textβ.Text = B.ToString();


        }

        private void SemnalulModulator_Click(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0, 150);
            pv.Size = new Size(700, 200);
            panel3.Controls.Add(pv);
            pv.Model = new PlotModel { Title = "Semnalul Modulator" };

            Func<double, double> fs1 = (x) => Am * Math.Cos(x);

            pv.Model.Series.Add(new FunctionSeries(fs1, Am, fp, 0.001));
        }



        private void SemnalulModulat_Click(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0, 450);
            pv.Size = new Size(700, 200);
            panel3.Controls.Add(pv);
            pv.Model = new PlotModel { Title = "Semnalul Modulat" };


            Func<double, double> fs2 = (x) => Ap * Math.Cos(wp * x + B * Math.Sin(wm * x));

            pv.Model.Series.Add(new FunctionSeries(fs2, Ap, fp, 0.001));
        }

        private void Capture_Click(object sender, EventArgs e)
        {
            g=Convert.ToString(textg.Text);
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@g);
            }

        }
    }

}
