namespace Task4_7
{//Вводится n. Определить количество цифр в числе
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n.");
            long n = Convert.ToInt64(Console.ReadLine());
            long number = 0;
            long n2 = n;
            if (n < 0)
            {
                n2 = -n;
            }
                do
                {
                    n2 /= 10;
                    number++;
                }
                while (n2 % 10 > 0);
                Console.WriteLine($"Количество цифр в числе {number}");
                Console.ReadKey();
            
        }
    }
}