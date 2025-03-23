namespace Task5_05
//Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию. Вывести отсортированный таким образом массив на экран
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            Console.Write($"Массив: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-50, 51);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.Write($"Массив, где первые 5 элементов упорядочены по возрастанию, вторые 5 - по убыванию: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
                Console.Write($"{array[i]} ");
            }
            for (int i = 5; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
                Console.Write($"{array[i]} ");
            }
            Console.ReadKey();
        }
    }
}
