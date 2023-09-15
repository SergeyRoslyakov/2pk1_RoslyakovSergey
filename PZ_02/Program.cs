namespace PZ_02
{
    using System;

    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double x, y, z;

            if (a > Math.PI)
            {
                x = Math.Cos(a + 2 * c);
            }
            else
            {
                x = c + Math.Sqrt(a * c * c - 2 * (a + Math.PI));
            }

            if (x <= 0)
            {
                y = Math.Log(a + c - x);
            }
            else
            {
                y = Math.Sin(2 * a * x) + Math.Sin(a + x);
            }

            z = (2 * x + 3 * y) * (Math.Pow(a, 2) - Math.Pow(c, 2));

            Console.WriteLine("Значение x: " + x);
            Console.WriteLine("Значение y: " + y);
            Console.WriteLine("Значение z: " + z);
        }
    }

}