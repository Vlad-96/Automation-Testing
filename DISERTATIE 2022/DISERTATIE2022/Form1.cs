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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MA_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulatiaAM ob = new ModulatiaAM();
            ob.Show();
        }

        private void DMA_Click(object sender, EventArgs e)
        {
            this.Hide();
            DemodulatiaInAmplitudine ob = new DemodulatiaInAmplitudine();
            ob.Show();

        }

        private void MF_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulatiaInFrecventa ob = new ModulatiaInFrecventa();
            ob.Show();
        }

        private void DMF_Click(object sender, EventArgs e)
        {
            this.Hide();
            DemodulatiaInFrecventa ob = new DemodulatiaInFrecventa();
            ob.Show();
        }

        private void MQAM_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulatiaQAM ob = new ModulatiaQAM();
            ob.Show();
        }

        private void DMQAM_Click(object sender, EventArgs e)
        {
            this.Hide();
            DemodulatiaQAM ob = new DemodulatiaQAM();
            ob.Show();
        }

        private void TransmisiaBB_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransmisiaBB ob = new TransmisiaBB();
            ob.Show();

        }

        private void Min_Click(object sender, EventArgs e)
        {
            
        }

        private void FullScreen_Click(object sender, EventArgs e)
        {
            
        }
    }
}
