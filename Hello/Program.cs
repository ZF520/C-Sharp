using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write 输出不换行
            Console.WriteLine("不换行");
            // WriteLine 输出换行
            Console.WriteLine("换行");
            // 等待、任意按键后继续执行
            Console.ReadKey();
            // ReadKey 输入会显示到屏幕上
            Console.WriteLine("换行");
            Console.ReadKey();
        }
    }
}
