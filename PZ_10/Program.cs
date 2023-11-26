namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "привет, как дела? привет, как хорошо.";

            // Разделение текста на предложения по знакам пунктуации
            string[] sentences = text.Split(new char[] { '.', '!', '?' });

            // Разделение каждого предложения на слова
            string[] words1 = sentences[0].Split(' ');
            string[] words2 = sentences[1].Split(' ');

            // Создание списка для хранения повторяющихся слов
            List<string> repeatedWords = new List<string>();

            // Поиск повторяющихся слов в обоих предложениях и добавление их в список
            foreach (string word1 in words1)
            {
                foreach (string word2 in words2)
                {
                    if (word1 == word2)
                    {
                        repeatedWords.Add(word1);
                        break;
                    }
                }
            }

            // Вывод повторяющихся слов на консоль
            foreach (string word in repeatedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}