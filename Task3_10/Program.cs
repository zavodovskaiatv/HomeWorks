namespace Task3_10
// Застройщик построил n домов. Вывести фразу «Мы построили n домов», обеспечив правильное согласование числа со словом «дом», например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во построенных домов.");
            uint n = Convert.ToUInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine($"Мы построили {n} дом.");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine($"Мы построили {n} дома.");
                    break;
                default:
                    Console.WriteLine($"Мы построили {n} домов.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
