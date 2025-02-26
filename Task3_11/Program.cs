namespace Task3_11
// Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров? Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры участка a * b в метрах:");
            Console.Write("а=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размеры первого дома p * q в метрах:");
            Console.Write("p=");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("q=");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размеры второго дома r * s в метрах:");
            Console.Write("r=");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("s=");
            int s = Convert.ToInt32(Console.ReadLine());
            // Проверяем корректность ввведенных  значений (-1 - Ошибка).
            int area = (a * b * p * q * r * s <= 0) ? -1 :
                       // Проверяем, хватает ли площади участка, чтобы разместить дома
                       (a * b < (p * q + r * s)) ? 0 :
                 // Проверяем, можно ли разместить дома, не разворачивая их в плане на 90 градусов
                 ((p + r <= a && Math.Max(q, s) <= b) ||
                 (Math.Max(p, r) <= a && q + s <= b)) ? 1 :
                 // Проверяем, можно ли разместить дома, развернув дом p*q на 90 градусов
                 ((q + r <= a && Math.Max(p, s) <= b) ||
                 (Math.Max(q, r) <= a && p + s <= b)) ? 1 :
                 // Проверяем, можно ли разместить дома, развернув дом r*s на 90 градусов
                 ((p + s <= a && Math.Max(q, r) <= b) ||
                 (Math.Max(p, s) <= a && q + r <= b)) ? 1 :
                 // Проверяем, можно ли разместить дома, развернув оба дома на 90 градусов
                 ((q + s <= a && Math.Max(p, r) <= b) ||
                 (Math.Max(q, s) <= a && p + r <= b)) ? 1 : 0;
            Console.WriteLine("Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров?");
            switch (area)
            {
                case -1:
                    Console.WriteLine("Ошибка.");
                    break;
                case 0:
                    Console.WriteLine("Нельзя.");
                    break;
                case 1:
                    Console.WriteLine("Можно.");
                    break;
            }
            Console.ReadKey();
        }
    }
}