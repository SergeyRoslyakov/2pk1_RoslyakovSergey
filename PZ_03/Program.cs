namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)

        {

            double area = 0;
            Console.WriteLine("Введите фигуру (круг, прямоугольник, треугольник):");
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "круг":
                    Console.WriteLine("Введите радиус круга:");
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
                case "прямоугольник":
                    Console.WriteLine("Введите ширину прямоугольника:");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите длину прямоугольника");
                    double length = double.Parse(Console.ReadLine());
                    area = width * length;
                    break;
                case "треугольник":
                    Console.WriteLine("Введите основание треугольника:");
                    double baseLength = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите высоту треугольника:");
                    double triangleHeight = double.Parse(Console.ReadLine());
                    area = 0.5 * baseLength * triangleHeight;
                    break;
                default:
                    Console.WriteLine("Неверная фигура.");
                    break;
            }
            Console.WriteLine($"Площадь {figure}а равна {area}");
        }
    }
}