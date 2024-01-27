//  Задача 2. Задайте двумерный массив. Напишите программу, 
//  которая поменяет местами первую и последнюю строку массива.

int[,] MassNums(int size, int size1, int from, int to)
{
    int[,] arr = new int[size, size1];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
        for (int j = 0; j < size1; j++)
            arr[i,j] = (n_new.Next(from, to));

    return arr;
}

void Print(int[,] arr)
{ 
    int size = arr.GetLength(0);
    int size1 = arr.GetLength(1);

    for (int i = 0; i < size; i++)
        {
        for (int j = 0; j < size1; j++)
            Console.Write($"{arr[i,j]} ");
        Console.WriteLine();
        }
}

int[,] SwapFirstLastRows(int[,] array)
{
    int size = array.GetLength(0);
    int size1 = array.GetLength(1);
    for (int j = 0; j < size1; j++)
    {
    (array[0,j], array[size - 1, j]) = (array[size - 1,j], array[0, j]);
    }
    return array;
}

Console.Clear();
Console.Write("Введите количество строк: ");
int Row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int Column = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(Row,Column,1,10);
Console.WriteLine("Сгенерированный массив:");
Print(mass);
Console.WriteLine("После замены строк в массиве:");
Print(SwapFirstLastRows(mass));