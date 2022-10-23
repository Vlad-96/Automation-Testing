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
    public partial class SpectrulMA : Form
    {
        public SpectrulMA()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModulatiaAM ob=new ModulatiaAM();
            ob.Show();
        }
    }
}
