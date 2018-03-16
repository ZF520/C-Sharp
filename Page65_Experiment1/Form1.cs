using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page65_Experiment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX.Text);
            double y;
            if (x < 1)
                y = x;
            else if (x >= 1 && x < 10)
                y = 2 * x - 1;
            else
                y = 3 * x - 11;
            txtY.Text = y.ToString();
        }
    }
}
