/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
int TheSecondDigitMethod(int num)

{
    int result;

    if (num < 100 || num > 999)
    {
        return 0;
    }

    else
    {
        result = num / 10 % 10;
    }

    return result;
}

Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int TheSecondDigitIs = TheSecondDigitMethod(num);
Console.WriteLine($"The second digit of three-digit number {num} is {TheSecondDigitIs}");
*/



/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

/*
int TheThirdDigitMethod(int num)

{
    int result;

    if (num > 99)
    {
        while (num > 1000)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    else
    {
        result = 0;
        
    }

    return result;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int TheThirdDigitIs = TheThirdDigitMethod(num);
if (num < 100)
{
    Console.WriteLine($"The third digit of {num} does not exist");
}
else
{
    Console.WriteLine($"The third digit of {num} is {TheThirdDigitIs}");
}
*/



/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/* Первый варинат решения без метода.*/

/*
Console.Write("Enter the day of the week from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 5)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
*/

/* Второй вариант решения с методом.*/


int TheWeekDayMethod(int num)
{
    int result;

    if (num > 5)
    {
        result = 1;
    }
    else
    {
        result = 0;
    }

    return result;
}

Console.Write("Enter the day of the week from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());

int TheWeekDay = TheWeekDayMethod(num);
if (num > 7)
{
    Console.WriteLine("Incorrect input. Try again.");
}
else
{
    if (TheWeekDay == 1)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
