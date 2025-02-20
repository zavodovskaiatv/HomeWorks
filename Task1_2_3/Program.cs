//Длина отрезка задана в дюймах (1 дюйм = 2,54 см). Перевести значение длины в метрическую систему, то есть выразить ее в метрах, сантиметрах и миллиметрах
namespace Task1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double i = 2.54;
            double l1 = Convert.ToDouble(Console.ReadLine());
            double l2 = l1 * i * 10; //перевод в мм
            int m = (int)(l2 / 1000);
            int cm = (int)((l2 % 1000) / 10);
            int mm = (int)(l2 % 10);
            Console.WriteLine("{0} дюйм(ов) = {1} м {2} см {3} мм", l1, m, cm, mm);
            Console.ReadKey();
        }
    }
}
