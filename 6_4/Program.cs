using System.Text;

namespace _6_4
//Запросите у пользователя имя, возраст и город. Сформируйте строку в формате: "Имя: [имя], Возраст: [возраст], Город: [город]" с использованием StringBuilder.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine().ToLower();
            int age;
            while (true)
            {
                Console.Write("Введите возраст: ");
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                    break;
                Console.WriteLine("Ошибка! Некорректный возраст.");
            }
            Console.Write("Введите город: ");
            string city = Console.ReadLine().ToLower();
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(name))
            {
                sb.Append("Имя: ").Append(char.ToUpper(name[0])).Append(name.Substring(1) + ", ");
            }
            sb.Append($"Возраст: {age}, ");
            if (!string.IsNullOrEmpty(city))
            {
                sb.Append("Город: " + char.ToUpper(city[0]) + city.Substring(1));
            }
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}