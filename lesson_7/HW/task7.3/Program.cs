//  Задача 3. Задайте произвольный массив. Выведете его элементы, 
//  начиная с конца. Использовать рекурсию, не использовать циклы.

Console.Clear();

void ReverseArr(int[] arr)      //функция для переворачивания массива (по заданию)
{
    if (arr.Length == 0)
        return;
    Console.Write(arr[arr.Length - 1] + " ");
    ReverseArr(arr.Take(arr.Length - 1).ToArray());
}

int[] MassNums(int size, int from, int to)      //функция для задания произвольного массива
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

Console.WriteLine("Введите количество элементов произвольного массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для задания массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для задания массива");
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, start, stop);
Console.WriteLine($"{string.Join(" ", mass)}");
ReverseArr(mass);