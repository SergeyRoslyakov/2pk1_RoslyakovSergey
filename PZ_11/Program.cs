namespace PZ_11
{
    internal class Program
    {
        static void RectPS(double x1, double y1, double x2, double y2, out double P, out double S)
        {
            double width = Math.Abs(x2 - x1);
            double height = Math.Abs(y2 - y1);

            P = 2 * (width + height); 
            S = width * height;
        }

        static void Main(string[] args)
        {
            double x1_1 = 0, y1_1 = 0, x2_1 = 2, y2_1 = 3; double P_1, S_1; RectPS(x1_1, y1_1, x2_1, y2_1, out P_1, out S_1); 
            double x1_2 = -1, y1_2 = -1, x2_2 = 5, y2_2 = 4; double P_2, S_2; RectPS(x1_2, y1_2, x2_2, y2_2, out P_2, out S_2); 
            double x1_3 = -2, y1_3 = -2, x2_3 = 2, y2_3 = 2; double P_3, S_3; RectPS(x1_3, y1_3, x2_3, y2_3, out P_3, out S_3);
            Console.WriteLine("Прямоугольник 1"); Console.WriteLine("Периметр: " + P_1); Console.WriteLine("Площадь: " + S_1);
            Console.WriteLine("Прямоугольник 2"); Console.WriteLine("Периметр: " + P_2); Console.WriteLine("Площадь: " + S_2);
            Console.WriteLine("Прямоугольник 3"); Console.WriteLine("Периметр: " + P_3); Console.WriteLine("Площадь: " + S_3);
        }
    }
}