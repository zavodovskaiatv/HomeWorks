//Вводится длина трубы в метрах. Округлить длину до целых в большую сторону.
namespace Task1_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение длины трубы в метрах:");
            double l = Convert.ToDouble(Console.ReadLine());
            double l2 = Math.Ceiling(l);
            Console.WriteLine("Длина трубы, округленная в большую сторону = {0}",l2);
            Console.ReadKey();
        }
    }
}
