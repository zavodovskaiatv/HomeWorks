using System.Text.RegularExpressions;

namespace _6_6
/*Составить регулярное выражение для проверки корректности пароля.
 * Пароль должен состоять минимум из 14 символов и иметь в составе минимум одну цифру, заглавную букву, строчную букву и специальный символ из набора !#;%:?*.
 * Запрашивать у пользователя пароль до тех пор, пока он не введет пароль, удовлетворяющий регулярному выражению.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[a-zA-Z0-9!#;%:?*]{14,}";
            Regex regex = new Regex(pattern);
            while (true)
            {
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                if (regex.IsMatch(password))
                break;
                Console.WriteLine("Пароль должен состоять минимум из 14 символов и иметь в составе минимум одну цифру, заглавную букву, строчную букву и специальный символ из набора !#;%:?*.");
            }
            Console.WriteLine("Пароль корректен.");
            Console.ReadKey();
        }
    }
}
