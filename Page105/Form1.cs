using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page105
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Undergraduate u;
            if (txtName.Text == "") u = new Undergraduate();
            else {
                int age = Convert.ToInt32(txtAge.Text);
                u = new Undergraduate(txtName.Text, age, txtSubject.Text);
            }
            lblShow.Text = u.GetMessage();
            lblShow.Text += "\n\n" + u.Study();
        }
    }
}
public class Student
{
    protected string name;
    protected int age;
    public Student(string name,int age)
    {
        this.name = name;
        this.age = age;
    }
    public string Study()
    {
        return string.Format("Student({0}):我今年{1}岁，我正在学习！", name, age);
    }
}
public class Undergraduate : Student
{
    private string subject;
    public Undergraduate():base("无名",0)
    {
        subject = "未知";
    }
    public Undergraduate(string name, int age, string subject) : base(name, age)
    {
        this.subject = subject;
    }
    public string GetMessage()
    {
        return string.Format("Undergraduate({0}):我今年{1}岁，我的专业是{2}！", name, age, subject);
    }
}
