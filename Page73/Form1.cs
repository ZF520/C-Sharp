﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            circle.Radius = Convert.ToDouble(txtRadius.Text);
            lblShow.Text = string.Format("半径为{0}的圆的面积为：{1}", circle.Radius, circle.Area);
        }
        class Circle
        {
            const double pi = 3.1415926;
            private double radius;
            public double Radius
            {
                get { return radius; }
                set {
                    if (value < 0) radius = 0;
                    else radius = value;
                }
            }
            public double Area
            {
                get { return pi * Radius * Radius; }
            }
        }
    }
}
