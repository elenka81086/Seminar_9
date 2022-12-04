/*Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


string ResultNumber(int N, int M) 
{ 
    if(N > M)
    {
        if(M == N)
        {
        return $"{M}";
        }
        return ResultNumber(N, M + 1) + ", " + M;
    }
    else 
    {
        if(M == N)
        {
            return $"{M}";
        }
        return ResultNumber(N, M - 1) + ", " + M;
    }
} 

int M = 1;
Console.Write("Введите значение N: "); 
int N = Convert.ToInt32(Console.ReadLine()); 
Console.Write(ResultNumber(N, M)); 
