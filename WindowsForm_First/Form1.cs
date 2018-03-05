using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "我的第一个window程序";
            Label lShow = new Label();
            lShow.Location = new Point(50, 30);
            lShow.AutoSize = true;
            lShow.Text = "本程序由小曾设计，欢迎您使用！";
            this.Controls.Add(lShow);
        }
    }
}
