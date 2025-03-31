namespace _7_4
// Напишите метод FindMax, который принимает переменное количество чисел и возвращает максимальное значение.
// Используйте ключевое слово params.
// Пример вызова:
// int maxNumber = FindMax(10, 25, 5, 30, 15);
// Console.WriteLine($"Max number: {maxNumber}"); // Вывод: Max number: 30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Передача нескольких чисел
            int max1 = FindMax(1, 2, 3, 4, 5);
            Console.WriteLine($"Максимальное число = {max1}");

            // Передеча другого набора чисел
            int max2 = FindMax(10, 15, -88);
            Console.WriteLine($"Максимальное число = {max2}");
            Console.ReadKey();
        }
        static int FindMax(params int[] numbers)
        {
            int max = 0;
            foreach (int a in numbers)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine("");
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
    }
}
