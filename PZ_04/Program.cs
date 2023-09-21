namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("задание 1");
            }
            int a = 10;
            int b = 60;
            int c = 3;

            for (int q = a; q <= b; q += c)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
            //
            //
            Console.WriteLine("задание 2");
            char sim = 'Д'; // Указанный символ (начальный символ)
            int n = 7; // Длина строки

            for (int p = 0; p < n; p++)
            {
                Console.Write((char)(sim + p));
            }
            Console.ReadLine();
            //
            //
            Console.WriteLine("задание 3");
            int rows = 9; // Количество строк
            int symbol = 5; // Количество символов в строке

            for (int t = 0; t < rows; t++)
            {
                for (int m = 0; m < symbol; m++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //
            //
            Console.WriteLine("задание 4");
            for (int e = -300; e <= 200; e += 7)
            {
                Console.Write(e + " ");
            }
            Console.ReadLine();
            //
            //
            Console.WriteLine("задание 5");
            int i = 5;
            int j = 82;

            for (; Math.Abs(i - j) >= 35; i++, j--)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }

            Console.WriteLine("Разница теперь составляет 35 или меньше.");
            Console.ReadLine();
        }
    }
}