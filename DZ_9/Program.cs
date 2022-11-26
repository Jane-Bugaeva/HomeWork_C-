﻿/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void ShowNums(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    ShowNums(n - 1);
}

ShowNums(8);




/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumOfNum(int n, int m)
{
    if (n < m) return n += SumOfNum(n + 1, m);
    if (n > m) return n += SumOfNum(n - 1, m);
    else return n;
}

Console.WriteLine(SumOfNum(4, 8));




/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int A(int n, int m) 
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return A(n - 1, 1);
        else
            return A(n - 1, A(n, m - 1));
}

Console.WriteLine(A(2, 3));