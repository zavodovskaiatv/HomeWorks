using System.Data;

namespace _7_1
//Два треугольника заданы длинами своих сторон. Определите, площадь какого из них больше (создайте метод Square для вычисления площади треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона.
//S = √(p × (p - a) × (p - b) × (p - c)) - формула герона.
//p = (a + b + c) / 2 - полупериметр
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] A = InputTriangleEdgesLenth("A");
            double[] B = InputTriangleEdgesLenth("B");
            double areaA = Square(A[0], A[1], A[2]);
            double areaB = Square(B[0], B[1], B[2]);
            if (areaA > areaB)
            {
                Console.WriteLine("Площадь треугольника А больше, чем площадь треугольника B.");
            }
            else if (areaA < areaB)
            {
                Console.WriteLine("Площадь треугольника А меньше, чем площадь треугольника B.");
            }
            else
            {
                Console.WriteLine("Площади треугольников А и B - равны.");
            }
            Console.ReadKey();
        }
        static double[] InputTriangleEdgesLenth(string triangleName) //Метод ввода сторон треугольника
        {
            Console.WriteLine($"Введите длины сторон треугольника {triangleName}:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            return new double[] { a, b, c };
        }
        static double Square(double n1, double n2, double n3)
        {
            //Проверка существования треугольника
            if (n1 <= 0 || n2 <= 0 || n3 <= 0 ||
            n1 + n2 <= n3 || n1 + n3 <= n2 || n2 + n3 <= n1)
            {
                Console.WriteLine("Треугольник с такими сторонами не существует");
            }
            //Формула Герона
            return Math.Sqrt((n1 + n2 + n3) / 2 * (((n1 + n2 + n3) / 2) - n1) * (((n1 + n2 + n3) / 2) - n2) * (((n1 + n2 + n3) / 2) - n3));
        }
    }
}
