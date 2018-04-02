using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page95_Experiment1
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            AddressBook addBook;
            addBook = new AddressBook(txtName.Text, txtPhone.Text, txtEmail.Text);
            lblShow.Text = addBook.GetMessage();
        }
    }
}
class AddressBook
{
    private string name;
    private string phone;
    private string email;
    public AddressBook(string name, string phone, string email) {
        this.name = name;
        this.phone = phone;
        this.email = email;
    }
    public string Name
    {
        get {
            if (name == null) return "未输入";
            else return name;
        }
    }
    public string Phone
    {
        get {
            if (phone == null) return "未输入";
            else return phone;
        }
        set {
            phone = value;
        }
    }
    public string Email {
        get {
            if (email == null) return "未输入";
            else return email;
        }
        set {
            email = value;
        }
    }
    public string GetMessage()
    {
        return string.Format("姓名：{0}\n电话：{1}\nEmail：{2}", Name, Phone, Email);
    }
}
