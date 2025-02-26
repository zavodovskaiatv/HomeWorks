namespace Task3_4
// Вводятся три разных числа. Вывести медиану – среднее по величине число.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 разных числа.");
            Console.WriteLine("1-е число:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-е число:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3-е число:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                Console.WriteLine("Ошибка. Присутсвуют равные числа.");
            }
            else if ((n1 > n2 && n1 < n3) || (n1 < n2 && n1 > n3))
            {
                Console.WriteLine("Медиана: {0}", n1);
            }
            else if ((n2 > n1 && n2 < n3) || (n2 < n1 && n2 > n3))
            {
                Console.WriteLine("Медиана: {0}", n2);
            }
            else
            {
                Console.WriteLine("Медиана: {0}", n3);
            }
            Console.ReadKey();
        }
    }
}
