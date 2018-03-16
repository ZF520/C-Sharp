using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            char ch_old, ch_new;
            ch_old = txtSource.Text[0];
            for (int i = 1; i < txtSource.Text.Length; i++)
            {
                ch_new = (char)txtSource.Text[i];
                if (ch_new == ch_old) continue;
                lblShow.Text += ch_new.ToString();
                ch_old = ch_new;
            }
        }
    }
}
