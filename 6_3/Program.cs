﻿namespace _6_3
/*Нужно создать отчёт, который будет содержать информацию о продажах за определённый период. Отчёт должен быть отформатирован следующим образом:

Название отчёта: "Отчёт о продажах за [месяц] [год]".

Информация о продажах:

    Общая сумма продаж.

    Количество проданных товаров.

    Средняя стоимость одного товара.

Общая сумма продаж должна быть отформатирована как денежная величина (с разделителями тысяч и двумя знаками после запятой).

Средняя стоимость товара должна быть округлена до двух знаков после запятой.

Пример данных:

Месяц: "Март"

Год: 2025

Общая сумма продаж: 1234567.89

Количество проданных товаров: 1234

Пример отчёта:

--------------------------------

Отчёт о продажах за Март 2025

--------------------------------

Общая сумма продаж: 1 234 567,89 р.

Количество проданных товаров: 1 234 шт.

Средняя стоимость товара: 1 000,46 р.

--------------------------------*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();
            Console.Write("Введите год: ");
            uint year = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Введите общую сумму продаж: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите кол-во проданных товаров: ");
            int sold = Convert.ToInt32(Console.ReadLine());
            decimal price = sum / sold;
            string formatedMonth = char.ToUpper(month[0]) + month.Substring(1);
            string str = string.Empty;
            str = string.Format("--------------------------------" +
                "\nОтчёт о продажах за {0} {1}" +
                "\n--------------------------------" +
                "\nОбщая сумма продаж: {2:0,0.00} р." +
                "\nКоличество проданных товаров: {3:0,0} шт." +
                "\nСредняя стоимость товара: {4:0,0.00} р.", formatedMonth, year, sum, sold, price);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
