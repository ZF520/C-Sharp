using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page82
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Book book;

        private void btnOK_Click(object sender, EventArgs e)
        {
            MidBook(book);
            txtTitle.Text = book.title;
            txtPrice.Text = book.price.ToString();
        }
        public void MidBook(Book newBook)
        {
            newBook.title = txtTiltleNew.Text;
            newBook.price = Convert.ToInt32(txtPriceNew.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            book = new Book();
            book.title = "Visual C#.NET程序设计教程；";
            book.price = 32;
            txtTitle.Text = book.title;
            txtPrice.Text = book.price.ToString();

        }
    }
    public class Book
    {
        public string title;
        public double price;
    }
}
