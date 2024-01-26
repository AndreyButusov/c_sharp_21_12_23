//  Задача 3: Напишите программу, которая перевернёт одномерный массив 
//  (первый элемент станет последним, второй – предпоследним и т.д.)

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

int[] UpsideDown(int[] arr)
{
    int size = arr.Length;
    int[] new_arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        new_arr[i] = arr[size - i - 1];
    }
    return new_arr;
}

/*
void RevMas(int[] arr_1)
{
    int size = arr_1.Length;

    for (int i = 0; i < size / 2; i++)
        (arr_1[i], arr_1[size - i - 1]) = (arr_1[size - i - 1], arr_1[i]);
}
*/

Console.WriteLine("Введите количество элементов массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение диапазона целых чисел для задания массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение диапазона целых чисел для задания массива");
int stop = int.Parse(Console.ReadLine()!);
        
int[] mass = MassNums(num, start, stop);
Console.Write("Заданный массив: ");
Print(mass);
//Print(RevMas(mass));
Console.Write("Перевернутый массив: ");
Print(UpsideDown(mass));