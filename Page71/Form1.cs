using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page71
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book book1;
            book1 = new Book();
            Book book2 = new Book();
            book1.title = "Visual C#.NET程序设计教程";
            book1.price = 32;
            String strMsg = book1.GetMessage();
            lblShow.Text = strMsg;
            book2.title = "数据结构";
            book2.price = 28;
            lblShow.Text += "\n\n" + book2.GetMessage();
        }
        public class Book
        {
            // 定义类的数据成员
            public string title;
            public double price;
            // 定义类的方法成员
            public string GetMessage()
            {
                return string.Format("书名：{0},价格：{1}元。", this.title, this.price);
            }
        }

    }
}
