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
    public partial class DemodulatiaInAmplitudine : Form
    {
        public DemodulatiaInAmplitudine()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ob = new Form1();
            ob.Show();
        }

        private void DemodulareaNecoerenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Demodularea_Necoerenta ob = new Demodularea_Necoerenta();
            ob.Show();

        }

        private void DemodulareaCoerenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Demodularea_Coerenta ob = new Demodularea_Coerenta();
            ob.Show();
        }
    }
}
