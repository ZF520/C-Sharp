using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page58
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
            StringBuilder sb = new StringBuilder();
            int i, j;
            for (i=1; i<=n; i++) {
                for (j = 1; j <= n - i; j++)
                {
                    sb.Append(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            lblShow.Text = sb.ToString();
        }
    }
}
