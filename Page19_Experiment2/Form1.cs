using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page19_Experiment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string strResult;
            strResult = "学号：" + txtID.Text + "\n姓名:" + txtName.Text + "\n性别" + txtSex.Text + "\n年龄：" + txtAge.Text + "\n专业：" + txtPart.Text;
            lblShow.Text = strResult;
        }
    }
}
