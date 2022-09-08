using System;
using System.Text.RegularExpressions;

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string writeOut = "Введите целое число день недели: ";
string helpQEnd = "Чтобы выйти из программы, введите символ \"q\" в терминале.";

Console.Clear();
Console.Write($"{helpQEnd}\nВведите целое число: ");

while(true) // Всегда работает
{
    
    try // Обработка исключения
    {
        string num3str = Console.ReadLine(); // Присваивает переменную из консоли
        string pattern = @"^\d+$"; // Regex, на наличие целых чисел
            if (Regex.IsMatch(num3str, pattern) && (int.Parse(num3str) >= 1 && int.Parse(num3str) <= 7)) // Если в строке есть цифры, то переходи на следующий уровень // Плюс, если длина строки равна 1, то, переходи дальше
            {   
                Console.Clear();
                int num3 = (Convert.ToInt32(int.Parse(num3str))); // Конвертация str num3str в int, и присваивает переменную num3
                Console.Write($"{helpQEnd}\nВведёное число {num3}, это: ");
                if(num3 == 1) Console.Write($"Понедельник. Будний день. Нет.\n");
                if(num3 == 2) Console.Write($"Вторник. Будний день. Нет.\n");
                if(num3 == 3) Console.Write($"Среда. Будний день. Нет.\n");
                if(num3 == 4) Console.Write($"Четверг. Будний день. Нет.\n");
                if(num3 == 5) Console.Write($"Пятница. Будний день. Нет.\n");
                if(num3 == 6) Console.Write($"Суббота. Выходной день. Да.\n");
                if(num3 == 7) Console.Write($"Воскресенье. Выходной день. Да.\n");
                Console.Write(writeOut);
            }

            else if (num3str.ToLower() == "q" || num3str.ToLower() == "й") // Если в строке присутствует символ "q" или "й", то переходи вниз
            {
                Console.Clear();
                Console.WriteLine("Выход из программы");
                break;
            }
            else // Иначе длина строки не равна 1, и // Иначе в строке присутствует кроме цифр ещё символ, который не относится к цифрам
            {
                Console.Clear();
                Console.Write($"{helpQEnd}\nВведёное число {int.Parse(num3str).ToString()}, не входит в день недели.\n"
                                +writeOut);
            }
        
    }
    catch(System.OverflowException) // Если показана ошибка OverflowException, тогда, зафиксируй её, и работай дальше.
    {
        Console.Clear();
        Console.Write("Ошибка. Значение было либо слишком большим, либо слишком маленьким.\n"
                     +$"{helpQEnd}\n"
                     +writeOut);
    }
    catch(System.FormatException) // Входная строка имела неправильный формат.
    {
        Console.Clear();
        Console.Write($"Ошибка. Входная строка имела неправильный формат.\n"
                     +$"{helpQEnd}\n"
                     +writeOut);
    }    
};