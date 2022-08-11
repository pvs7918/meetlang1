/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int N;       //исходное число
int i;
string str;

Console.WriteLine("Введите число N: ");
N = int.Parse(Console.ReadLine()!);

Console.Write($"Четные числа от 1 до {N}: ");    
    
str = "";
i = 1;

while (i <= N)
{
    if (i%2 == 0)
    {
        if (str.Length == 0)
        {
            str = str + i;
        }
        else
        {
            str = str + ", " + i;
        }
    }
    i++;
}
Console.Write(str);