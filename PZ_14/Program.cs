namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Nexus\\Desktop\\Папка)\\Новый текстовый документ.txt";
            if (File.Exists(filePath)) // Проверяем, существует ли файл
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        char[] sortedChars = lines[i].ToCharArray();
                        Array.Sort(sortedChars);
                        lines[i] = new string(sortedChars);
                    }
                    File.WriteAllLines(filePath, lines);
                    Console.WriteLine("Сортировка символов в файле выполнена успешно.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Произошла ошибка: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Файл не существует.");
            }
        }
    }
}
