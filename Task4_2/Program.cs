namespace Task4_2
{//Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n.");
            ulong n = Convert.ToUInt64(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Число не является натуральным.");
            }
            else
            {
                double sum = 0;
                for (ulong i = 1; i <= n; i++)
                {
                    sum += 1.0 / i;
                }
                Console.WriteLine($"Сумма частных равна {sum}.");
                Console.ReadKey();
            }
        }
    }
}
