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
    public partial class TransmisiaBB : Form
    {
        double n, ΔΦ, N, Δφ, np, flocal, fatac, tbit, ts;
            public TransmisiaBB()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }

        private void Calculeaza1_Click(object sender, EventArgs e)
        {
            n=Convert.ToDouble(textn.Text);

            ΔΦ=360/Math.Pow(2,n);

            textΔΦ.Text= ΔΦ.ToString();

        }

        private void Calculeaza2_Click(object sender, EventArgs e)
        {
            N = Convert.ToDouble(text1.Text);

            Δφ = 360 / Math.Pow(2, N);

            text2.Text = Δφ.ToString();

        }

        private void Calculeaza3_Click(object sender, EventArgs e)
        {
            np = (ΔΦ - Δφ) / Δφ;

            text3.Text=np.ToString();   
        }

        private void Calculeaza4_Click(object sender, EventArgs e)
        {
            flocal = Convert.ToDouble(text4.Text);

            fatac = Math.Pow(2, N) * flocal;

            text5.Text=fatac.ToString();    
        }

        private void Calculeaza5_Click(object sender, EventArgs e)
        {
            tbit = Convert.ToDouble(text6.Text);

            ts = (np + 1) * tbit;

            text7.Text=ts.ToString();       

        }
    }
}
