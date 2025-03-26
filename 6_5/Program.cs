using System.Text.RegularExpressions;

namespace _6_5
//Составить регулярное выражение для проверки корректности номера телефона. Корректный номер имеет формат +7(123)456-78-90.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] test =
            {
                "+7(123)456-78-90",
                "+7(923)123-45-67",
                "8(123)456-78-90",
                "+7123456789",
                "89231234576",
                "8-123-456-78-90",
                "+7 123 456 78 90",
                "Тел. +7(123)456-78-90"
            };
            string pattern = @"^\+7\(\d{3}\)\d{3}-\d{2}-\d{2}$";
            Regex regex = new Regex(pattern);
            foreach (string str in test)
            {
                if (regex.IsMatch(str))
                {
                    Console.WriteLine("{0,-22} - номер корректен.", str);
                }
                else
                {
                    Console.WriteLine("{0,-22} - номер не корректен.", str);
                }
            }
            Console.ReadKey();
        }
    }
}
