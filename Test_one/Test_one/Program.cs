using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1--用户输入两个整数，计算两个整数的和,平均数
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());//"12" 12
            int c = a + b;
            Console.WriteLine("sum =" + c);
            Console.WriteLine("average =" + Convert.ToDouble(c) / 2);//or c / 2.0
            //2--交换a和b
            int t = a;
            a = b;
            b = t;
            Console.WriteLine("a =" + a + " b = " + b);
            //3--优先级输出
            Console.WriteLine("{0},{1},{2}", a, b, c);
        }
    }
}
