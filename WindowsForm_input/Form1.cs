﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            string strResult;
            strResult = txtName.Text + ",你好！欢迎使用本程序！";
            lblShow.Text = strResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
