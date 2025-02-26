namespace Task3_2
// Вводятся три числа. Вывести большее их них.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа.");
            Console.WriteLine("1-е число:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-е число:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3-е число:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            int max = (n1 >= n2 && n1 >= n3) ? n1 : (n2 >= n1 && n2 >= n3) ? n2 : n3;
            Console.WriteLine("Наибольшее число: {0}", max);
            Console.ReadKey();
        }
    }
}
