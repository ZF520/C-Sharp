using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page95_Experiment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Time time = new Time();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            time.AddSecond();
            lblHour.Text = Convert.ToString(time.Hour);
            lblMinute.Text = Convert.ToString(time.Minute);
            lblSecond.Text = Convert.ToString(time.Second);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lblHour.Text = Convert.ToString(time.Hour);
            lblMinute.Text = Convert.ToString(time.Minute);
            lblSecond.Text = Convert.ToString(time.Second);
        }
    }
}
class Time
{
    private int hour;
    private int minute;
    private int second;
    public Time()
    {
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;
        second = System.DateTime.Now.Second;
    }
    public Time(int h, int m, int s) {
        hour = h;
        minute = m;
        second = s;
    }
    public int Hour {
        get {return hour;}
    }
    public int Minute {
        get { return minute; }
    }
    public int Second {
        get { return second; }
    }
    public void AddSecond() {
        second++;
        if (second >= 60) {
            second = second % 60;
            minute++;
        }
        if (minute >= 60) {
            minute = minute % 60;
            hour++;
        }
    }
}
