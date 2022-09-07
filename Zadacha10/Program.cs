using System;
using System.Text.RegularExpressions;

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.Write("Введите целое трёхзначное число: ");

while(true)
{
    string num3str = Console.ReadLine();
    int lengthString = num3str.Length;
    string pattern = @"^\d+$";
    if (lengthString == 3 && Regex.IsMatch(num3str, pattern))
    {   
        int num3 = ((Int32.Parse(num3str)) / 10) % 10;
        Console.WriteLine(num3);
        break;
    }
    else
    {
        if (num3str.ToLower() != "q")
        {
            Console.Write("Ошибка! Введите целое трёхзначное число: ");
        }
        else
        {
            Console.WriteLine("Выход из программы");
            break;
        }
        
    }
};


