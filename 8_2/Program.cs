namespace _8_2
// Напишите метод ValidateAge, проверяющий корректность возраста. Если возраст:
// •    < 0 - выбросить ArgumentException("Возраст не может быть отрицательным"),
// •    > 150 - выбросить ArgumentOutOfRangeException("Слишком большой возраст").
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите возраст.");
                int age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
                Console.WriteLine("Введенный возраст корректен.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка: некорректный формат числа.");
            }
            finally
            {
                Console.WriteLine("Проверка возраста завершена.");
            }
            Console.ReadKey();
        }
        static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("возраст не может быть отрицательным.");
            }
            if (age > 150)
            {
                throw new ArgumentException("cлишком большой возраст.");
            }
        }
    }
}
