namespace Task3_1
// Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=».
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Правильный знак:");
            if (n1 == n2)
            {
                Console.WriteLine("=");
            }
            else if (n1 > n2)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("<");
            }
            Console.ReadKey();
        }
    }
}
