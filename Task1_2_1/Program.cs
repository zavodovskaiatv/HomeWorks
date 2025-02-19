// Вводятся три числа. Обменять их местами циклически. Например, вводятся a=1, b=2, c=3. После обмена в переменных должны оказаться значения a=3, b=1, c=2.
namespace Task1_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int t = c;
            c = b;
            b = a;
            a = t;
            Console.WriteLine("a={0},b={1},c={2}", a, b, c);
            Console.ReadKey();
        }
    }
}
