/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 < n2)
{
    Console.WriteLine("Maximum number is "+ n2);
    Console.WriteLine("Minimum number is "+ n1);
}
else
{
    Console.WriteLine("Maximum number is "+ n1);
    Console.WriteLine("Minimum number is "+ n2); 
}
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 & n1 > n3)
{
    Console.WriteLine("Maximum number is "+ n1);
}
if (n2 > n1 & n2 > n3)
{
    Console.WriteLine("Maximum number is "+ n2);
}
if (n3 > n1 & n3 > n2)
{
    Console.WriteLine("Maximum number is "+ n3);
}
*/

/* 
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int n2 = n1 % 2;

if (n2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Console.Write("Input positive number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current < n1+1)
{
    Console.Write(current + " ");
    current = current + 2;
}

if (n1 < 1)
{
    Console.WriteLine("Incorrect input. Try again.");
}
*/
