//Вводятся два числа. Обменять их местами, не используя третью переменную.
namespace Task1_2_7_со_звездочкой
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a={0},b={1}", b, a);
            Console.ReadKey();
        }
    }
}
