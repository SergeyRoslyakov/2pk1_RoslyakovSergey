namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ввод строки с датой в начале
            Console.WriteLine("Введите строку с датой в формате 'DD month YYYY':");
            string inputString = Console.ReadLine();

            // Разделение строки на слова
            string[] words = inputString.Split(' ');

            // Проверка наличия обязательных элементов
            if (words.Length < 4)
            {
                Console.WriteLine("Введена некорректная строка.");
                return;
            }

            // Получение даты из первых трех элементов
            string day = words[0];
            string month = words[1];
            string year = words[2];

            // Преобразование месяца в числовой формат
            int numericMonth = GetNumericMonth(month);

            // Проверка корректности месяца
            if (numericMonth == -1)
            {
                Console.WriteLine("Введен некорректный месяц.");
                return;
            }

            // Форматирование даты
            string formattedDate = $"{day}.{numericMonth:D2}.{year}"; // D2 добавляет ведущий ноль для месяца < 10

            // Создание новой строки с форматированной датой
            string outputString = formattedDate + " " + string.Join(" ", words, 3, words.Length - 3);

            // Вывод новой строки на экран
            Console.WriteLine("Преобразованная строка:");
            Console.WriteLine(outputString);
        }

        // Метод для преобразования текстового месяца в числовой формат
        static int GetNumericMonth(string month)
        {
            switch (month.ToLower())
            {
                case "января":
                    return 1;
                case "февраля":
                    return 2;
                case "марта":
                    return 3;
                case "апреля":
                    return 4;
                case "мая":
                    return 5;
                case "июня":
                    return 6;
                case "июля":
                    return 7;
                case "августа":
                    return 8;
                case "сентября":
                    return 9;
                case "октября":
                    return 10;
                case "ноября":
                    return 11;
                case "декабря":
                    return 12;
                default:
                    return -1;
            }
        }
    }
}