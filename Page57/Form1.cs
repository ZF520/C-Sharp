using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String str = txtString.Text;
            int count = 0;
            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
                    count++;
            }
            lblShow.Text = string.Format("字符串中包括{0}个英文字母！", count);
        }
    }
}
