/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


double StepenMethod(double numOne, double numTwo)
{
    double result = Math.Pow(numOne, numTwo);
    return result;
}

Console.Write("Введите первое число: ");
double numOne = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double numTwo = Convert.ToDouble(Console.ReadLine());

double TheResult = StepenMethod( numOne, numTwo);
Console.WriteLine($"Если возвести число {numOne} в степень {numTwo} получится {TheResult}");




/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


int SumDigitMethod(int num)
{
    int SumDigit = 0;
    while (num > 0)
    {
        SumDigit = num % 10 + SumDigit;
        num = num / 10;
    }
    return SumDigit;
}

Console.Write("Введите любое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());


int SumDigitIs = SumDigitMethod(num);
Console.WriteLine($"Сумма всех цифр числа {num} равна {SumDigitIs}");


/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
m = 5 -> [1, 2, 5, 7, 19]
m = 3 -> [6, 1, 33]
*/

int[] DigitMethod (int num)
{
    int [] array = new int[num];
    for (int i = 0; i < num; i++)
    array[i] = new Random().Next(1, 100);
    return array;

}

void ResultMethod (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();

}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] ResultArray = DigitMethod(num);
ResultMethod(ResultArray);