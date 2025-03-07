namespace Task4_6
{//Вводится n. Определить, является ли оно степенью 2-ки?
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n.");
            double n = Convert.ToDouble(Console.ReadLine());
            int i = 0;
            do
            {
                i++;
                if (n / i == i)
                {
                    Console.WriteLine("Число является степенью двойки.");
                    break;
                }
            }
            while (i < n);
            if (!(n / i == i))
            {
                Console.WriteLine("Число не является степенью двойки.");
            }
            Console.ReadKey();
        }
    }
}
