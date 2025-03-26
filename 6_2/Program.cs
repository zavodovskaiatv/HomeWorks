namespace _6_2
//Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Составить программу, определяющую, является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются:");
            string input = Console.ReadLine();
            input = input.Replace(" ", "");
            string result = "Это палиндром.";
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    result = "Это не палиндром.";
                    break;
                }
            }  
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
