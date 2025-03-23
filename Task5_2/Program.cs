namespace Task5_02
// Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20]. Определить количество положительных, отрицательных и равных нулю элементов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int a = 0;
            int b = 0;
            int c = 0;
            Console.Write($"{n} случайных числел: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-20, 21);
                Console.Write($"{array[i]} ");
                if (array[i] > 0)
                {
                    a++;
                }
                else if (array[i] < 0)
                {
                    b++;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Количество положительных элементов: {a}");
            Console.WriteLine($"Количество отрицательных элементов: {b}");
            Console.WriteLine($"Количество равных нулю элементов: {c}");
            Console.ReadKey();
        }
    }
}
