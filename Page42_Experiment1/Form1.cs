using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page42_Experiment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtCelsius!=null)
            {
                double c = Convert.ToInt32(txtCelsius.Text);
                double f = 9.0 / 5 * c + 32;
                txtFahrenheit.Text = f.ToString();
                
            }
           
            //if (txtFahrenheit != null)
            //{
            //    double f = Convert.ToInt32(txtFahrenheit.Text);
            //    double c = 9.0 / 5 * f + 32;
            //    txtCelsius.Text = c.ToString();
            //}


        }
    }
}
