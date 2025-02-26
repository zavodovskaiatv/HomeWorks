namespace Task3_6
// Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число четное?");
            switch (n % 2)
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
