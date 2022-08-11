/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

int numb;       //исходное число
int remainder;  //остаток от деления

Console.WriteLine("Введите число: ");
numb = int.Parse(Console.ReadLine()!);

remainder = numb % 2;

Console.WriteLine("Является ли введённое число чётным?");    
Console.Write(" -> ");    
 
if (remainder == 0)
{
    Console.WriteLine("да");    
}
else
{
    Console.WriteLine("нет");    
}