using System;
using System.Text.RegularExpressions;

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// void is_this_day_off(bool dayOff)
// {
//     if (dayOff)
//     {
//         return "Да";
//     }
//     else
//     {
//         return "Нет";
//     };
// };

// void Checking_for_days_of_the_week(int num)
// {
//     if(num == 6 || num == 7)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     };
// };

// void Checking_for_days_of_the_week(int num)
// {
//     if(num == 6 || num == 7)
//     {
//         return "Да";
//     }
//     else
//     {
//         return "Нет";
//     }
// }



Console.Write("Чтобы выйти из программы, введите символ \"q\" в терминале.\nВведите целое число: ");

while(true) // Всегда работает
{
    try // Обработка исключения
    {
        string num3str = Console.ReadLine(); // Присваивает переменную из консоли
        string pattern = @"^\d+$"; // Regex, на наличие целых чисел
            if (int.Parse(num3str).ToString().Length == 1 && Regex.IsMatch(num3str, pattern)) // Если в строке есть цифры, то переходи на следующий уровень // Плюс, если длина строки равна 1, то, переходи дальше
            {   
                // bool dayWeek;
                // string yesNo;
                int num3 = (Convert.ToInt32(int.Parse(num3str))); // Конвертация str num3str в int, и присваивает переменную num3
                //bool days_of_the_week = Checking_for_days_of_the_week(num3, out dayWeek);
                //string isDayOff = is_this_day_off(days_of_the_week, out yesNo);
                string isDayOff = Checking_for_days_of_the_week(num3);

                Console.Write($"Чтобы выйти из программы, введите символ \"q\" в терминале.\nВведёное число {num3}, это выходной? {isDayOff}\n"
                        +"Введите целое число день недели: ");

            }

            else if (num3str.ToLower() == "q" || num3str.ToLower() == "й") // Если в строке присутствует символ "q" или "й", то переходи вниз
            {
                Console.WriteLine("Выход из программы");
                break;
            }
            else // Иначе длина строки не равна 1, и // Иначе в строке присутствует кроме цифр ещё символ, который не относится к цифрам
            {
                Console.Write($"Чтобы выйти из программы, введите символ \"q\" в терминале.\nВведёное число {int.Parse(num3str).ToString()}, не входит в день недели.\n"
                                +"Введите целое число день недели: ");
            }
        
    }
    catch(System.OverflowException) // Если показана ошибка OverflowException, тогда, зафиксируй её, и работай дальше.
    {
        Console.Write("Ошибка. Значение было либо слишком большим, либо слишком маленьким.\n"
                     +"Чтобы выйти из программы, введите символ \"q\" в терминале.\n"
                     +"Введите целое трёхзначное число: ");
    }    
};