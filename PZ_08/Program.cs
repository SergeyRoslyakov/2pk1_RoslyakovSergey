namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1: Создание ступенчатого массива с рандомной длиной второго измерения
            Random random = new Random();
            int[][] array = new int[9][];
            for (int i = 0; i < array.Length; i++)
            {
                int length = random.Next(10, 21);
                array[i] = new int[length];
            }

            // Заполнение массива рандомными значениями от 1 до 100
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(1, 101);
                }
            }

            // Задание 2: Вывод сгенерированного массива
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Задание 3: Создание нового одномерного массива и запись последних элементов каждой строки
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i][array[i].Length - 1];
            }

            // Задание 4: Вывод нового массива
            Console.WriteLine("\nНовый массив с последними элементами каждой строки:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();

            // Нахождение максимального элемента в каждой строке и запись их в другой массив
            int[] maxElements = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int max = array[i][0];
                for (int j = 1; j < array[i].Length; j++)
                {
                    if (array[i][j] > max)
                    {
                        max = array[i][j];
                    }
                }
                maxElements[i] = max;
            }

            // Задание 5: Вывод массива с максимальными элементами
            Console.WriteLine("\nМассив с максимальными элементами в каждой строке:");
            for (int i = 0; i < maxElements.Length; i++)
            {
                Console.Write(maxElements[i] + " ");
            }
            Console.WriteLine();

            // Обмен первого элемента и максимального в каждой строке
            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = Array.IndexOf(array[i], maxElements[i]);
                int temp = array[i][0];
                array[i][0] = array[i][maxIndex];
                array[i][maxIndex] = temp;
            }

            // Вывод обновленного массива
            Console.WriteLine("\nОбновленный массив после обмена первого элемента и максимального в каждой строке:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Задание 6: Реверс каждой строки ступенчатого массива
            for (int i = 0; i < array.Length; i++)
            {
                Array.Reverse(array[i]);
            }

            // Вывод массива после реверса строк
            Console.WriteLine("\nМассив после реверса каждой строки:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Задание 7.: Подсчет среднего значения в каждой строке
            double[] averages = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
                averages[i] = sum / array[i].Length;
            }

            // Вывод средних значений в каждой строке
            Console.WriteLine("\nСредние значения в каждой строке:");
            for (int i = 0; i < averages.Length; i++)
            {
                Console.WriteLine("Строка " + (i + 1) + ": " + averages[i]);
            }

            // Задание 7.b: Подсчет общего количества символов в строках каждой строки массива
            int[] charactersCount = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    charactersCount[i] += array[i][j].ToString().Length;
                }
            }

            // Вывод общего количества символов в каждой строке массива
            Console.WriteLine("\nОбщее количество символов в каждой строке:");
            for (int i = 0; i < charactersCount.Length; i++)
            {
                Console.WriteLine("Строка " + (i + 1) + ": " + charactersCount[i]);
            }
        }
    }
}