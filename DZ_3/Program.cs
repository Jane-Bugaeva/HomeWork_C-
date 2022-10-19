/* 
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


void PalindromMethod(int num)
{
    
    if (num > 9999 && num < 100000)
    {
        if ((num % 10) == (num / 10000) && (num % 100) / 10 == (num / 1000) % 10)
        {
            Console.WriteLine("Число является палиндромом");
        }
        if ((num % 10) > (num / 10000) || ((num % 10) < (num / 10000)))
        {
            Console.WriteLine("Число не является палиндромом");
        }        
    }
    
    if (num < 9999 || num > 100000)
    {
        Console.WriteLine("Введеное число не является пятизначным. Попробуйте снова.");
    }

}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

PalindromMethod(num);




/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


double The3DMethod (double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ) 
{
  double distance = Math.Sqrt((secondX - firstX) * (secondX - firstX) + (secondY - firstY) * (secondY - firstY) + (secondZ - firstZ) * (secondZ - firstZ));
  return Math.Round(distance, 5);
}

Console.Write("Введите данные X первого числа: ");
double firstX = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите данные Y первого числа: ");
double firstY = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите данные Z второго числа: ");
double firstZ = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите данные X второго числа: ");
double secondX = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите данные Y второго числа: ");
double secondY = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите данные Z второго числа: ");
double secondZ = Convert.ToDouble(Console.ReadLine());

Console.Write( $"Расстояние между двумя точками в 3D пространстве: {The3DMethod (firstX, firstY, firstZ, secondX, secondY, secondZ)}");



/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


void KubMethod(int num) 
{
    for (int i = 1; i <= num; i = i + 1)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
KubMethod(num);
