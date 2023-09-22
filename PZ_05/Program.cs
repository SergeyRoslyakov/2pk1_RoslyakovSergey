namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double h = 0.2;
            double y;

            do
            {
                y = 8 * x + 4 * Math.Pow(x, 4) - 1.5 * Math.Pow(x, 3);
                Console.WriteLine("x = {0}, y = {1}", x, y);
                x += h;
            } while (x <= 3);
        }
    }
}
