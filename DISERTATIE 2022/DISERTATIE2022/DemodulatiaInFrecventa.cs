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
    public partial class DemodulatiaInFrecventa : Form
    {
        public DemodulatiaInFrecventa()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ob = new Form1();
            ob.Show();
        }

        private void Demodulare1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Demodulareprinderivareșidetecțiedeanvelopă ob = new Demodulareprinderivareșidetecțiedeanvelopă();
            ob.Show();
        }

        private void Demodulare2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DemodularecubuclaPLL ob = new DemodularecubuclaPLL();
            ob.Show();
        }
    }
}
