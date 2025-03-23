namespace Task5_04
//Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10]. Перевернуть массив, т.е. переставить элементы массива в обратном порядке
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
                array[i] = rnd.Next(0, 11);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.Write($"Массив в обратном порядке: ");
            int[] reversedArray = new int[n];
            for (int i = 0;i < n; i++)
            {
                reversedArray[i] = array[n-1-i];
                Console.Write($"{reversedArray[i]} ");
            }
            Console.ReadKey();
        }
    }
}
