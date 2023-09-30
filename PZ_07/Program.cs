namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int size = matrix.GetLength(0);
        int product = 1;

            for (int i = 0; i < size; i++)
            {
                int diagonalElement = matrix[i, i];
                if (diagonalElement != 0)
                {
                    product *= diagonalElement;
                }
            }

                Console.WriteLine("Произведение ненулевых диагональных элементов: " + product);

                Console.ReadLine();
        }
    }
}