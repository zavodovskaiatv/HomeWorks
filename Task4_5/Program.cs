namespace Task4_5
{//Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Введите число:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 20 || n > 60);
            Console.WriteLine("Введенное число входит в диапазон [20; 60]");
            Console.ReadKey();
        }
    }
}

