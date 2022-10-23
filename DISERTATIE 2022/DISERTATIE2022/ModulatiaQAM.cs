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

namespace DISERTATIE2022
{
    public partial class ModulatiaQAM : Form
    {

        
        public ModulatiaQAM()
        {
            InitializeComponent();
        }

       

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ob = new Form1();
            ob.Show();
        }

        

     
    }
}
