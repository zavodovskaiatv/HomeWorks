namespace Task5_08
//Сформировать одномерный массив из 5 случайных чисел из диапазона [0, 10]. Найти два наибольших элемента. Например, среди чисел {4, 8, 0, 9, 3} два наибольших числа – 9 и 8. Среди чисел {5, 9, 1, 9, 3} два наибольших числа – 9 и 9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] array = new int[n];
            Random rnd = new Random();
            Console.WriteLine($"Массив: ");
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 11);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            foreach (int t in array)
                if (t > max1)
                {
                    max2 = max1;
                    max1 = t;
                }
                else if (t > max2)
                {
                    max2 = t;
                }
            Console.WriteLine("Два наибольших числа: {0}, {1}", max1, max2);
            Console.ReadKey();
        }
    }
}
