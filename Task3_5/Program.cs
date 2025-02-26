namespace Task3_5
// Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число заканчивается на 0?");
            switch (n % 10)
            {
                case 0:
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
