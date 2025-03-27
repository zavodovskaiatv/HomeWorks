using System.Runtime.InteropServices;

namespace _7_3
// Напишите метод PrintNumbers, который выводит на экран числа из массива.У метода должен быть необязательный параметр reverse, который по умолчанию равен false. Если reverse равен true, числа выводятся в обратном порядке.
// Пример вызова:
//int[] numbers = { 1, 2, 3, 4, 5 };
//PrintNumbers(numbers); // Вывод: 1 2 3 4 5
//PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            PrintNumbers(numbers);
            Console.WriteLine("");
            PrintNumbers(numbers, true);
            Console.ReadKey();
        }
        static void PrintNumbers(int[] array, bool reverse = false)
        {
            if (reverse)
            {
                foreach (int a in array)
                {
                    Console.Write($"{a} ");
                }
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
