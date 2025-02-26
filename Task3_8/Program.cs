namespace Task3_8
// Вводится число. Вывести «Да», если оно попадает в диапазон [-10,10], и «Нет» в противном случае.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число попадает в диапазон [-10,10]?");
            if (n >= -10 && n <= 10)
            {
                Console.WriteLine("Да.");
            }
            else
            {
                Console.WriteLine("Нет.");
            }
                Console.ReadKey();
        }
    }
}
