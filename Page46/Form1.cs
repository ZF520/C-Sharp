using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txtShow.Text);
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                lblShow.Text = year + "年是闰年!";
            }
            else
            {
                lblShow.Text = year + "年不是闰年！";
            }
        }
    }
}
