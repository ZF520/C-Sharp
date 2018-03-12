using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double score = Convert.ToDouble(txtShow.Text);
            switch ((int)(score / 10))
            {
                case 10:
                case 9:
                    lblShow.Text = "您的成绩为：优";break;
                case 8:
                    lblShow.Text = "您的成绩为：良"; break;
                case 7:
                    lblShow.Text = "您的成绩为：中"; break;
                case 6:
                    lblShow.Text = "您的成绩为：及格"; break;
                default:
                    lblShow.Text = "您的成绩为：不及格";break;
            }
        }
    }
}
