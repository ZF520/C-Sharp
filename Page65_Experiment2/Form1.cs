using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page65_Experiment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtOriginal.Text);
            int turnNum = 0;
            while(num>0)
            {
                turnNum = turnNum * 10 + num % 10;
                num = num / 10;
            }
            txtTurn.Text = turnNum.ToString();
        }
    }
}
