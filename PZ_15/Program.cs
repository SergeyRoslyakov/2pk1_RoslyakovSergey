namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Program Files"; // Указываем путь
            if (Directory.Exists(path)) // Проверяем существование каталога
            {
                var directories = new DirectoryInfo(path).GetDirectories();
                Array.Sort(directories, (x, y) => y.Name.Length.CompareTo(x.Name.Length));

                foreach (var directory in directories)
                {
                    Console.WriteLine(directory.Name); // Выводим отсортированные каталоги в консоль
                }
            }
            else
            {
                Console.WriteLine("Каталог не существует");
            }
        }
    }
}