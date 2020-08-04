using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionLoop
{
    class Program
    {
        // định nghĩa hằng gợi nhớ
        const double EPSILON = 0.0000001;

        // định nghĩa hàm tính giai thừa
        static long giaithua(int n)
        {
            if (n <= 1) return 1;
            return n * giaithua(n - 1);
        }

        // định nghĩa thành phần hàm tính x^n/n!
        static double EnS1(double x, int n)
        {
            return (Math.Pow(x, n)) / giaithua(n);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
