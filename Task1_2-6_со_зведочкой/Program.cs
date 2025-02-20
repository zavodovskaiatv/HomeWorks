//Вводится длина трубы в метрах. Округлить длину до 0,5
namespace Task1_2_6_со_зведочкой
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение длины трубы в метрах:");
            double l = Convert.ToDouble(Console.ReadLine());
            double l2 = Math.Round(l * 2) / 2;
            Console.WriteLine("Длина трубы, округленная до 0,5 = {0}", l2);
            Console.ReadKey();
        }
    }
}
