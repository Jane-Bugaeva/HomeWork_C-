/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(minVal, maxVal + 1);
        }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int PositiveMethod(int[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) 
            count++;
    return count;
}

Console.Write("Введите длинну массива: ");

int num = Convert.ToInt32(Console.ReadLine());
int[] array  = CreateRandomArray(num, 100, 1000);

ShowArray (array);

Console.WriteLine($"-> {PositiveMethod(array)}");
*/



/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(minVal, maxVal + 1);
        }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int SumMethod(int[] array) 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if(i % 2 != 0) 
            sum += array[i];
    return sum;

}

Console.Write("Введите длинну массива: ");

int num = Convert.ToInt32(Console.ReadLine());
int[] array  = CreateRandomArray(num, -100, 100);

ShowArray (array);

Console.WriteLine($"-> {SumMethod(array)}");
*/



/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

/*
int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(minVal, maxVal + 1);
        }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int MinMaxMethod(int[] array) 
{
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
            min = array[i];
        if(max < array[i])
            max = array[i];
    }
    return max - min;
}

Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array  = CreateRandomArray(size, 1, 100);

ShowArray(array);

Console.WriteLine($"-> {MinMaxMethod(array)}");
*/