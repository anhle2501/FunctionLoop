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

        // định nghĩa hàm tính công thức S1(x)
        static double S1(double x)
        {
            // lúc đầu thiết lập S=1 và n=1
            double S = 1;
            int n = 1;
            double En;
            do
            {
                // tính En tích lũy En vào S
                En = EnS1(x, n);
                S = S + En;
                n++;
            } while (Math.Abs(En) >= EPSILON); // lắp lại bước 2 nếu En>=epsilon
            return S; // gởi kết quả về lệnh này
        }
        
        // định nghĩa hàm thành paahfn (-1)^nx^n/n!
        static double EnS2(double x, int n)
        {
            return Math.Pow(-1, n) * Math.Pow(x, n) / giaithua(n);
        }

        // định nghĩa hàm tính công thức S2(x)
        static double S2(double x)
        {
            //thiết lập S = 1 và n = 1
            double S = 1;
            int n = 1;
            double En;
            do
            {
                //tính En tích lũy En vào S
                En = EnS2(x, n);
                S = S + En;
                n++;
            } while (Math.Abs(En) >= EPSILON); // lặp lại nếu En >= epsilon
            return S;
        }

        static double S3(double x)
        {
            double S=1;
            int n = 1;
            double En;
            do
            {
                En = Math.Sin(n * x);
                S = S + En;
                n++;
            } while (Math.Abs(En) >= EPSILON);
            return S;
        }

        // chương trình dùng thử
        static void Main(string[] args)
        {
            double x;
            String buf;
            // yêu cầu người dùng nhập x
            Console.Write("Nhap x:");
            buf = Console.ReadLine();
            x = Double.Parse(buf);
            //gọi hàm S1(x)
            Console.WriteLine("S1(" + x + ")=" + S1(x));
            //gọi hàm S2(x)
            Console.WriteLine("S2(" + x + ")=" + S2(x));
            //gọi hàm S3(x)
            Console.WriteLine("S3(" + x + ")=" + S3(x));
        }
    }
}
