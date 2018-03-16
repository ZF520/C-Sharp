using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page65_Experiment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int i, j, sum;
            for (i = 2; i < 1000; i++)
            {
                sum = 0;
                for (j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0) sum += j;
                }
                if (sum == i)
                {
                    sb.Append(i + "是一个完数:" + i + "=1");
                    for (j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0) sb.Append("+" + j);
                    }
                    sb.Append("\n");
                }
            }
            lblShow.Text = sb.ToString();
        }
    }
}
