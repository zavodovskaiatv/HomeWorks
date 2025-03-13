namespace Task5_03
{
    //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50]. Найти и вывести значение максимального, минимального элементов и их индексы
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            Console.Write($"{n} случайных числел: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 51);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine(".");
            int max = array[0];
            int min = array[0];
            int maxI = 0;
            int minI = 0;
            for (int i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxI = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    minI = i;
                }
            }
            Console.WriteLine($"Значение максимального элемента: {max}, его индекс равен: {maxI}.");
            Console.WriteLine($"Значение максимального элемента: {min}, его индекс равен: {minI}.");
            Console.ReadKey();
        }
    }
}
