using System;

namespace Task3_12
/* Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например:
 * 256 — «двести пятьдесят шесть», 
 * 814 — «восемьсот четырнадцать».
 * Если пользователь введёт данные не соответствующие условию задачи
 * - выдать сообщение об ошибке.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число в диапазоне 100–999:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            if (n < 100 || n > 999)
            {
                Console.WriteLine("Ошибка: число вне диапазона 100–999.");
            }
            uint a = n / 100;
            uint b = (n / 10) % 10;
            uint c = n % 10;
            Console.WriteLine("");
            Console.WriteLine("Число прописью:");
            switch (a)
            {
                case 1:
                    Console.Write("сто");
                    break;
                case 2:
                    Console.Write("двести");
                    break;
                case 3:
                    Console.Write("триста");
                    break;
                case 4:
                    Console.Write("четыреста");
                    break;
                case 5:
                    Console.Write("пятьсот");
                    break;
                case 6:
                    Console.Write("шетьсот");
                    break;
                case 7:
                    Console.Write("семьсот");
                    break;
                case 8:
                    Console.Write("восемьсот");
                    break;
                case 9:
                    Console.Write("девятьсот");
                    break;
            }
            switch (b)
            {
                case 0:
                    Console.Write("");
                    break;
                case 1:
                    {
                        switch (c)
                        {
                            case 0:
                                Console.Write(" десять");
                                break;
                            case 1:
                                Console.Write(" одинадцать");
                                break;
                            case 2:
                                Console.Write(" двенадцать");
                                break;
                            case 3:
                                Console.Write(" тринадцать");
                                break;
                            case 4:
                                Console.Write(" четырнадцать");
                                break;
                            case 5:
                                Console.Write(" пятнадцать");
                                break;
                            case 6:
                                Console.Write(" шестнадцать");
                                break;
                            case 7:
                                Console.Write(" семнадцать");
                                break;
                            case 8:
                                Console.Write(" восемнадцать");
                                break;
                            case 9:
                                Console.Write(" девятнадцать");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.Write(" двадцать");
                    break;
                case 3:
                    Console.Write(" тридцать");
                    break;
                case 4:
                    Console.Write(" сорок");
                    break;
                case 5:
                    Console.Write(" пятьдесят");
                    break;
                case 6:
                    Console.Write(" шестьдесят");
                    break;
                case 7:
                    Console.Write(" семьдесят");
                    break;
                case 8:
                    Console.Write(" восемьдесят");
                    break;
                case 9:
                    Console.Write(" девяносто");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            if (!(b == 1))
            {
                switch (c)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write(" один");
                        break;
                    case 2:
                        Console.Write(" два");
                        break;
                    case 3:
                        Console.Write(" три");
                        break;
                    case 4:
                        Console.Write(" четыре");
                        break;
                    case 5:
                        Console.Write(" пять");
                        break;
                    case 6:
                        Console.Write(" шесть");
                        break;
                    case 7:
                        Console.Write(" семь");
                        break;
                    case 8:
                        Console.Write(" восемь");
                        break;
                    case 9:
                        Console.Write(" девять");
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
            Console.Write(".");
            Console.ReadKey();
        }
    }
}