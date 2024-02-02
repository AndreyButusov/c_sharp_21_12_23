//  Задача 1. Задайте двумерный массив символов (тип char [,]). 
//  Создать строку из символов этого массива.

Console.Clear();

char[,] MassRandomSymbol(int row, int column)       //Создание массива рандомных символов
{
    char[,] arr = new char[row, column];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = Convert.ToChar(rnd.Next('a', 'a' + 26));

    return arr;
}

void Print(char[,] arr)     //Функция для отображения созданного массива (чтобы проверить правильность алгоритма)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

void PrintStr(char[,] arr)      //Функция вывода массива в строку
{
    char[,] mass = new char[arr.GetLength(0), arr.GetLength(1)];
    string result = "";
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result += arr[i,j];
        }
    }
    Console.WriteLine(result);
}

Console.Write("Количество строк создаваемого массива: ");
int Row = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов создаваемого массива: ");
int Column = int.Parse(Console.ReadLine()!);
char[,] mass = MassRandomSymbol(Row,Column);
Console.WriteLine($"Созданный массив: ");
Print(mass);
Console.Write($"Массив в строку: ");
PrintStr(mass);