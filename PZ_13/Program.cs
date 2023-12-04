using System;

namespace PZ_13
{
    internal class Program
    {
        // Задание 1
        static double Calculate(int n, double a, double d)
        {
            if (n == 1)
            {
                return a;
            }
            else
            {
                return Calculate(n - 1, a + d, d);
            }
        }

        // Задание 2
        static double GeomPR(int n, double firstel, double step)
        {
            if (n == 1)
                return firstel;
            else
                return GeomPR(n - 1, firstel, step) * step;
        }

        // Задание 3
        static void Poryadok(int a, int b)
        {
            if (a < b)
            {
                Console.Write(a + " ");
                Poryadok(a + 1, b);
            }
            else if (b < a)
            {
                Console.Write(a + " ");
                Poryadok(a - 1, b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }

        // Задание 4
        static int Summ(int x)
        {
            if (x == 1)
                return x;
            return x + Summ(x - 1);
        }

        static void Main()
        {
            Console.WriteLine("Первое задание:");
            int n = 6;
            double a1 = -1;
            double d = -0.2;
            double res1 = Calculate(n, a1, d);
            Console.WriteLine(res1);

            Console.WriteLine("Второе задание:");
            int n2 = 5;
            double firstel2 = 11;
            double step2 = -3;
            double res2 = GeomPR(n2, firstel2, step2);
            Console.WriteLine(res2);

            Console.WriteLine("Третье задание:");
            int a = 79;
            int b = 33;
            Poryadok(a, b);

            Console.WriteLine("Четвёртое задание:");
            int x = 5;
            int res4 = Summ(x);
            Console.WriteLine(res4);
        }
    }
}