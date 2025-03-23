namespace Task5_07
//Сформировать двумерный массив из 10 строк и 5 столбцов. Заполнить его случайными числами в диапазоне [0, 10]. Определить максимальный элемент в каждой строке
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int[,] array = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int max = 0;
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(0, 11);
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine("     max = {0}", max);
            }
            Console.ReadKey();
        }
    }
}
