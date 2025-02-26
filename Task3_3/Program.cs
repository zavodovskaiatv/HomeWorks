using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Task3_3
// Вводятся четыре числа. Вывести большее из них.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4 числа.");
            Console.WriteLine("1-е число:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-е число:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3-е число:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4-е число");
            int n4 = Convert.ToInt32(Console.ReadLine());
            int max = n1;
            if (n2 > max)
            {
                max = n2;
            }
            if (n3 > max)
            {
                max = n3;
            }
            if (n4 > max)
            {
                max = n4;
            }
            Console.WriteLine("Наибольшее число: {0}", max);
            Console.ReadKey();
        }
    }
}
