//  Задайте двумерный массив из целых чисел. Сформируйте новый
//  одномерный массив, состоящий из средних арифметических
//  значений по строкам двумерного массива.

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

double[] CreateNewMass(int[,] array)
{
    int size = array.GetLength(0);
    int size1 = array.GetLength(1);
    double[] new_arr = new double[size];
    
    for (int i = 0; i < size; i++)
    {
        double Average = 0;
        for (int j = 0; j < size1; j++)
        {
            Average += array[i,j];
        }
        new_arr[i] = Average / size1;
        
    }
    return new_arr;
}
Console.Clear();
Console.Write("Введите количество строк: ");
int Row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int Column = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(Row,Column,1,10);
Console.WriteLine("Сгенерированный массив:");
Print(mass);
Console.WriteLine("Новый массив:");
Console.WriteLine(string.Join(", ", CreateNewMass(mass)));