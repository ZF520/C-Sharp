using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page59
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNum.Text);
            int flag = 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    flag = 0;
                    break;
                }
            }
            if (flag == 1) lblShow.Text = n + "是一个质数";
            else lblShow.Text = n + "不是一个质数";
        }
    }
}
