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
using System.Drawing.Imaging;


namespace DISERTATIE2022
{
    public partial class GenerareaSemnaluluiMA : Form
    {
        double Vo,fc, wc,gm,gc,m,fmM,f1,f2,LB;
        string g;

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

        public GenerareaSemnaluluiMA()
        {
            InitializeComponent();
        }

       

        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ModulatiaAM ob = new ModulatiaAM();
            ob.Show();
        }

        

        private void CaalculeazaPulsatiaCentrala_Click(object sender, EventArgs e)
        {
            fc = Convert.ToDouble(textfc.Text);
            wc = 2 * 3.14 * fc;

            textwc.Text = wc.ToString();
        }

        private void CalculeazaIndiceledeModulatie_Click(object sender, EventArgs e)
        {
            gm = Convert.ToDouble(textgm.Text);
            gc = Convert.ToDouble(textgc.Text);

            m = gm / gc;

            textm.Text = m.ToString();
            
        }



        private void CalculeazafmM_Click(object sender, EventArgs e)
        {
            fmM = Convert.ToDouble(textfmM.Text);

            f1 = fc - fmM;

            f2 = fc + fmM;

            textf1.Text = f1.ToString();
            textf2.Text = f2.ToString();

            LB = 2 * fmM;

            textLB.Text = LB.ToString();

        }




        private void SemnalulModulator_Click(object sender, EventArgs e)
        {
            
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0,0);
            pv.Size = new Size(700,250);
            panel4.Controls.Add(pv);

            pv.Model = new PlotModel { Title="Semnalul Modulator"};

            Func<double, double> fs1 = (x) =>  gc+gm*Math.Sin(x);

            pv.Model.Series.Add(new FunctionSeries(fs1,gm,fc,0.0001));
            

        }



        private void SemnalulPurtator_Click(object sender, EventArgs e)
        {
            Vo = Convert.ToDouble(textVo.Text);
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0, 250);
            pv.Size = new Size(700, 250);
            panel4.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Purtator" };

            Func<double, double> fs2 = (x) => Vo*Math.Cos(x);

            pv.Model.Series.Add(new FunctionSeries(fs2, Vo, fc, 0.001));


        }

        private void SemnalulModulat_Click(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0, 490);
            pv.Size = new Size(700, 250);
            panel4.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Semnalul Modulat" };

            Func<double, double> fs3 = (x) => Vo * gc*(1+m*Math.Sin(x))*Math.Cos(x);

            pv.Model.Series.Add(new FunctionSeries(fs3, Vo, fc, 0.0001));

        }


        

    }
}
