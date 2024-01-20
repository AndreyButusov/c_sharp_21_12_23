//  Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.

void Print(int[] arr)
{ 
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

int CountingEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0 && arr[i] != 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите количество элементов массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение диапазона целых чисел для задания массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение диапазона целых чисел для задания массива");
int stop = int.Parse(Console.ReadLine()!);
if (start < 100 || stop > 999)
    {
        Console.WriteLine("Ошибка! В массиве посторонние числа!");
    }
    else
    {      
        int[] mass = MassNums(num, start, stop);
        Console.Write("Заданный массив: ");
        Print(mass);
        Console.WriteLine($"В заданном массиве {CountingEvenNumbers(mass)} четных чисел");
    }

