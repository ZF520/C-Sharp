using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int i;
            double t, s1, s2;
            s1 = t = 0.1;
            s2 = 100000;
            for (i = 2; i <= 30; i++)
            {
                t = t * 2;
                s1 = s1 + t;
                s2 = s2 + 100000;
            }
            lblShow.Text = String.Format("百万富翁给陌生人{0:N2}元。\n陌生人给百万富翁{1:N2}元。", s1, s2);
        }
    }
}
