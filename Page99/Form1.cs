using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 创建Books型的数组对象，用来记录5本图书的信息
        Books[] bs = new Books[5];
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // cbbType.SelectedIndex表示组合框中选择的项的索引，第一项的索引为0
            Type type = cbbType.SelectedIndex == 0 ? Type.Computer : Type.Novel;
            double price = Convert.ToDouble(txtPrice.Text);
            // 用Books.count获得当前的图书数目，以此作为索引号，并创建一个新的Books对象
            bs[Books.count] = new Books(txtTitle.Text, type, price);
            Books.count++;
            lblShow.Text = string.Format("添加成功:{0}本书", Books.count);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblShow.Text = string.Format("\n计算机类图书总数：{0}", Books.NumberComputers());
            lblShow.Text += string.Format("\n小说类图书总数:{0}", Books.NumberNovels);
            lblShow.Text += string.Format("\n图书名单如下:\n");
            foreach (Books b in  bs)
            {
                if (b != null)
                    lblShow.Text += string.Format("{0}\n", b.title);
            }
        }
    }
}
public enum Type { Computer,Novel};
public class Books
{
    // 私有静态字段，分别统计计算机类和小说类的书目数量
    private static int computer, novel;
    // 公共静态字段，统计总图书数量
    public static int count;
    //公共字段，描述书名信息
    public string title;
    public Type type;
    public double price;
    // 构造函数，用来初始化对象
    public Books(string title, Type type, double price)
    {
        this.title = title;
        this.type = type;
        this.price = price;
        if (type == Type.Computer) computer++;
        if (type == Type.Novel) novel++;
    }
    // 静态方法，返回计算机类图书数量
    public static int NumberComputers()
    {
        return computer;
    }
    // 静态方法属性，返回小说类图书数量
    public static int NumberNovels
    {
        get { return novel; }
    }
}