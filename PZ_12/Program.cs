namespace PZ_12
{
    internal class Program
    {
        static void fullsum(double firstsum, int months)
        {
            double interestamount = (firstsum < 100000) ? 0.05 : 0.08;
            double totalamount = firstsum;

            for (int i = 0; i < months; i++)
            {
                totalamount += totalamount * interestamount;
            }

            Console.WriteLine("Сумма к концу срока: " + totalamount);
        }

        static void Main()
        {
            double depositamount = 100001; // Cумма вклада
            int depositinmonths = 12; // Срок вклада в месяцах
            fullsum(depositamount, depositinmonths);
        }
    }
}