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
    public partial class ModulatiaAM : Form
    {
        public ModulatiaAM()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void SpectrulSemnaluluiMA_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpectrulMA ob = new SpectrulMA();
            ob.Show();
        }

        private void GenerareaSemnaluluiMA_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerareaSemnaluluiMA ob = new GenerareaSemnaluluiMA();
            ob.Show();
        }

        private void GenerareaSemnaluluiMABLDPS_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerareaSemnaluluiMaBLDPS ob = new GenerareaSemnaluluiMaBLDPS();
            ob.Show();
        }
    }
}
