﻿/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
Выполнил Сергиенко П.В. 11.08.2022г.
*/

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine($"max = {num1}");
}
else
{
    if (num2 > num1)
    {
        Console.WriteLine($"max = {num2}");
    }
    else
    {
        Console.WriteLine("Числа равны!");
    }
}
