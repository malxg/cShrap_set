using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        struct Vector3
        {
            public double x;
            public double y;
            public double z;
            public double Distance()
            {
                double temp = Math.Pow(x,2) + Math.Pow(y, 2) + Math.Pow(z, 2);
                return Math.Sqrt(temp);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("a");
            /*
            for(int i = 0;i <= 9;i ++)
            {
                Console.Write();
            }*/
            /*//judge youngster and teenager
            int age = Convert.ToInt32(Console.ReadLine());
            bool result = age >= 18 && age <= 60;
            Console.WriteLine(result);

            int a = 1;
            if (a == 1)//c里面可以if(a = 1) 结果为True执行
            {
                Console.WriteLine("123");
            }
            
            int i = 0;
            do
            {
                i++;
                Console.WriteLine("123");
            }while (i <= 3);
            int[] ages = { 1, 3, 4, 5 };
            Console.WriteLine(ages[1]);
            
            int[] ages = new int[11];
            ages[0] = 1;
            
            Console.Write(3333 + "2332" + '\n');//换行加'\n'
            Console.WriteLine(3333 + "2332");//自动换行
            
            //字符串操作函数
            string name = @"   Jack and Alex 123 \\n   ";
            //ToLower()大写转换为小写(不影响原字符串)
            Console.WriteLine(name.ToLower() + '\n' + name);
            //ToUpper()大写转换为小写(数字不动)
            Console.WriteLine(name.ToUpper());
            //Trim()去除前后空格，译为修剪
            //TrimStart()去除前,TrimEnd()去除后空格
            Console.WriteLine(name.Trim() + '\n' +
                name.TrimStart() + '\n' +
                name.TrimEnd() + "abc");
            
            string m = "m,n,c,e";
            string[] p = m.Split(',');
            foreach(string str in p)
            {
                Console.WriteLine(str);
            }
            */

            Vector3 vector = new Vector3();
            vector.x = 4;
            vector.y = 5;
            vector.z = 7;
            Console.WriteLine(vector.Distance());

        }
    }
}