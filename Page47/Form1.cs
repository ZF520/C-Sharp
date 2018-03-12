using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double h, w, t;
            h = Convert.ToDouble(txtHeight.Text);
            w = Convert.ToDouble(txtWeight.Text);
            t = w / (h * h);
            if (t < 18)
                lblShow.Text = "您的身体偏瘦！";
            else if (t >= 18 && t < 25)
                lblShow.Text = "您的身体完全标准！";
            else if (t >= 25 && t < 27)
                lblShow.Text = "您的身体完全偏胖！";
            else
                lblShow.Text = "您的身体有点肥胖！";
        }
    }
}
