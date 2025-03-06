namespace Task4_1
{//Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.
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
                double factorial = 1;
                for (ulong i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Факториал числа {n} равен {factorial}.");
                Console.ReadKey();
            }
        }
    }
}
