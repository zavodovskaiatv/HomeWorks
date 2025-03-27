namespace _7_5
// Напишите перегруженные методы Multiply, которые могут умножать два числа (целые или дробные) и возвращать результат.
// Пример вызова:
// Console.WriteLine(Multiply(2, 3)); // Вывод: 6
// Console.WriteLine(Multiply(2.5, 3.5)); // Вывод: 8.75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(5, 4));
            Console.WriteLine(String.Format("{0:F2}", Multiply(5.2, 2.1)));
            Console.ReadKey();
        }
        static int Multiply(int a, int b)
        {
            Console.Write($"{a}*{b}=");
            return a * b;
        }
        static double Multiply(double a, double b)
        {
            Console.Write($"{a}*{b}=");
            return a * b;
        }
    }
}
