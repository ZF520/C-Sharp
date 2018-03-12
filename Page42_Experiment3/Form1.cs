using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page42_Experiment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double[] a = new double[5];
        int i = 0;
        private void add_Click(object sender, EventArgs e)
        {
            double element = double.Parse(txtAdd.Text);
            a[i] = element;
            txtPrior.Text += a[i] + " ";
            i++;
            lblNo.Text = "请输入第" + (i + 1) + "个元素";
        }

        private void sort_Click(object sender, EventArgs e)
        {
            Array.Sort(a);
            txtSort.Text = a[0] + " " + a[1] + " " + a[2] + " " + a[3] + " " + a[4];
        }
    }
}
