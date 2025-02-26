namespace Task3_9
// Вводится число. Вывести «Да», если оно попадает в диапазон (-∞; -10] Ս [10; +∞), и «Нет» в противном случае.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число.");
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Число попадает в диапазон (-∞; -10] Ս [10; +∞)?");
            switch (n)
            {
                case <= -10:
                case >= 10:
                    Console.WriteLine("Да.");
                    break;
                default:
                    Console.WriteLine("Нет.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
