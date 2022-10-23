using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISERTATIE2022
{
    public partial class GMD : Form
    {
        double kd, ke, fc, deltawm, wc;
        string g;


        public GMD()
        {
            InitializeComponent();
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Demodulareprinderivareșidetecțiedeanvelopă ob = new Demodulareprinderivareșidetecțiedeanvelopă();
            ob.Show();      
        }

        private void Calculeaza_Click(object sender, EventArgs e)
        {
            kd = Convert.ToDouble(textkd.Text);
            ke = Convert.ToDouble(textke.Text);
            fc = Convert.ToDouble(textfc.Text);
            deltawm = Convert.ToDouble(textkd.Text);

            wc = 2 * 3.14 * fc;

            textwc.Text=wc.ToString();  
        }


        private void Detecţiadeanvelopă_Click(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0, 0);
            pv.Size = new Size(700, 250);
            sec1.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Generat in Urma Detectiei de Anvelopa" };

            Func<double, double> fs1 = (x) => kd * ke * (4 / 3.14) * wc +kd * ke * (4/3.14) * deltawm * Math.Sin(x);

            pv.Model.Series.Add(new FunctionSeries(fs1, kd, fc, 0.001));
        }


        private void Eliminareacomponenteicontinue_Click(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0, 0);
            pv.Size = new Size(700, 250);
            sec2.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Generat in Urma Eliminarii Componentei Continue" };

            Func<double, double> fs1 = (x) => kd * ke * (4 / 3.14) * deltawm * Math.Sin(x);

            pv.Model.Series.Add(new FunctionSeries(fs1, kd, fc, 0.001));
        }
    }
}
