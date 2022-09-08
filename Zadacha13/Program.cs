﻿using System;
using System.Text.RegularExpressions;

// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
Console.Write("Чтобы выйти из программы, введите символ \"q\" в терминале.\nВведите целое трёхзначное число: ");

while(true) // Всегда работает
{
    try // Обработка исключения
    {
        string num3str = Console.ReadLine(); // Присваивает переменную из консоли
        string pattern = @"^\d+$"; // Regex, на наличие целых чисел
        if (Regex.IsMatch(num3str, pattern)) // Если в строке есть цифры, то переходи на следующий уровень
        {
            if (int.Parse(num3str).ToString().Length >= 3 && Regex.IsMatch(num3str, pattern)) // Плюс, если длина строки больше или равна 3, то, переходи дальше
            {   
                int num3 = (Convert.ToInt32(int.Parse(num3str).ToString()[2].ToString())); // Конвертация str num3str в int, и присваивает переменную num3
                Console.Write($"Чтобы выйти из программы, введите символ \"q\" в терминале.\nВведёное число {num3}\n"
                                +"Введите целое трёхзначное число: ");
            }
            else // Иначе длина строки меньше 3
            {
                Console.Write($"Чтобы выйти из программы, введите символ \"q\" в терминале.\nВведёное число {int.Parse(num3str).ToString()} нет третьей цифры.\n"
                             +"Введите целое трёхзначное число: ");
            }
        }
        else // Иначе в строке присутствует кроме цифр ещё символ, который не относится к цифрам
        {
                if (num3str.ToLower() == "q" || num3str.ToLower() == "й") // Если в строке присутствует символ "q" или "й", то переходи вниз
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
                else // Иначе
                {
                    Console.Write("Чтобы выйти из программы, введите символ \"q\" в терминале.\nЭто не число! Введите целое трёхзначное число: ");
                }
        }
    }
    catch(System.OverflowException) // Если показана ошибка OverflowException, тогда, зафиксируй её, и работай дальше.
    {
        Console.Write("Ошибка. Значение было либо слишком большим, либо слишком маленьким.\n"
                     +"Чтобы выйти из программы, введите символ \"q\" в терминале.\n"
                     +"Введите целое трёхзначное число: ");
    }    
};