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
    public partial class Demodularea_Coerenta : Form
    {
        double A0, a, Vref,fc;
        string g;
        public Demodularea_Coerenta()
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

        private void Demodularea_Coerenta_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            DemodulatiaInAmplitudine ob = new DemodulatiaInAmplitudine();
            ob.Show();
        }

        private void SemnalulDemodulat_Click(object sender, EventArgs e)
        {
            A0 = Convert.ToDouble(textA0.Text);
            a = Convert.ToDouble(texta.Text);
            Vref = Convert.ToDouble(textVref.Text);
            fc = Convert.ToDouble(textfc.Text);

            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Size = new Size(700, 250);
            p.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Demodulat" };

            Func<double, double> fs1 = (x) =>(A0 * a *Math.Sin(x))/(4*Vref);

            pv.Model.Series.Add(new FunctionSeries(fs1, A0, fc, 0.0001));
        }
    }
}
