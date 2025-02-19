//Угол а задан в градусах, минутах и секундах. Найти его величину в радианах.
namespace Task1_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deg = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int sec = Convert.ToInt32(Console.ReadLine());
            double rad = (deg * Math.PI / 180) + (min * Math.PI / (180 * 60)) + (sec * Math.PI / (180 * 60 * 60));
            Console.WriteLine(rad);
            Console.ReadKey();
        }
    }
}
