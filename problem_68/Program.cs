﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int AckermanFunction(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0 && m > 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}
Console.Write("Введите значение m: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите значение n: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine();
Console.Write($"При m = {m} и n = {n} функция Аккермана = {AckermanFunction (m, n)}"); 
