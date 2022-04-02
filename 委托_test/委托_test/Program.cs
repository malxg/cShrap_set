using System;
namespace _048_delegate
{
    class Program
    {
        static double Multiply(double param1,double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }
        delegate double MyDelegate(double param1, double param2);
        static void Main(string [] args)
        {
            Console.WriteLine(Multiply(2.3, 2));
            Console.WriteLine(Divide(4.5, 3));

            //entrust
            MyDelegate delegate1;
            delegate1 = Multiply;
            Console.WriteLine(delegate1(2,4));
        }
    }
}