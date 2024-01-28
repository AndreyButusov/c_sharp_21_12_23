//  Задача 3. Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

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

// Вычисление сумм по строкам (на выходе массив с суммами строк)
int[] SumRows(int[,] array)
{
    int[] ArrSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            ArrSum[i] += array[i,j];
    }
    return ArrSum;
}

// Получение индекса минимального элемента в одномерном массиве 
int MinIndex(int[] array)
{
    int MinIndex = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinIndex)
            MinIndex = array[i];
    }
    return MinIndex;
}

Console.Clear();
Console.Write("Введите количество строк: ");
int Row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int Column = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(Row,Column,1,10);
Console.WriteLine("Сгенерированный массив:");
Print(mass);
Console.WriteLine(string.Join(" ", SumRows(mass)));
int Min = MinIndex(SumRows(mass));
Console.Write($"Наименьшая сумма элементов в строке: {Min}");
