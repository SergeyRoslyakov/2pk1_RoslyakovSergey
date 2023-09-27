namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, -3, -5, 2, 5 };
            int minIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < Math.Abs(array[minIndex]))
                {
                    minIndex = i;
                }
            }

            Console.WriteLine("Минимальный по модулю элемент: " + array[minIndex]);
            Console.WriteLine("Номер минимального по модулю элемента: " + (minIndex + 1));
        }
    }
}