namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 1;
            double c = Math.PI / 2;

            double result = Math.Log(5) / Math.Sin(c) - Math.Sqrt(Math.Abs(-2.5 - Math.Pow(a, 2))) - (Math.Pow(10, 3) * a - b) / Math.Cos(b) + +Math.Pow(Math.Abs(-5 - Math.Pow(a, 2)), 1 / 3) - 2.5 * c;
            
            Console.WriteLine(result);
        }
    }
}