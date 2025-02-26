namespace Task3_7
// Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число.");
            long n = Convert.ToInt64 (Console.ReadLine());
            Console.WriteLine("Число является двухзначным?");
            switch (n)
            {
                case <= 9:
                case >= 100:
                    Console.WriteLine("Нет.");
                    break;
                default:
                    Console.WriteLine("Да.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
