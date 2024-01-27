//  Задача 1. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание, 
//  что такого элемента нет: "Позиция по рядам выходит за пределы массива"
//  или "Позиция по колонкам выходит за пределы массива"

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

void FindElement(int[,] mass, int numrow, int numcolumn)
{
    if (numrow >= mass.GetLength(0) || numcolumn >= mass.GetLength(1))
        Console.WriteLine("Позиция по колонкам выходит за пределы массива");
    for (int i = 0; i < mass.GetLength(0); i++)
        {
        for (int j = 0; j < mass.GetLength(1); j++)
            if (i == numrow && j == numcolumn)
            Console.WriteLine($"Запрошенный элемент массива имеет значение {mass[i,j]}");
        }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int Row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int Column = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(Row,Column,1,10);
Console.WriteLine("Сгенерированный массив:");
Print(mass);
Console.Write("Введите координату строки искомого элемента: ");
int numrow = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату столбца искомого элемента: ");
int numcolumn = int.Parse(Console.ReadLine()!);
FindElement(mass, numrow, numcolumn);