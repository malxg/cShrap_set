using System;
using System.Collections.Generic;
using System.Linq;
using System.Text
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
                double temp = x * y * z;
                return Math.Sqrt(temp);
            }
        }

        static void Main(string[] args)
        {
            
            Vector3 vector = new Vector3();
            vector.x = 3;
            vector.y = 3;
            vector.z = 3;
            Console.WriteLine(vector.Distance());

        }
    }
}
