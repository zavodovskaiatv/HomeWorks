namespace Task4_3
{//Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число а>0:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число b>0:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Числа не соответсвует условию.");
            }
            else
            {
                double power = 1;
                for (int i = 1; i <= b; i++)
                {
                    power *= a;
                }
                Console.WriteLine($"{a}^{b}={power}");
                Console.ReadKey();
            }
        }
    }
}
