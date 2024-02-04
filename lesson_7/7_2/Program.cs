//  Задача 2. Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от 1 до N.

void Interval(int N)
{
    if (N == 0)
        return;
    Interval(N-1);
    Console.Write(N + " ");
}

Console.Clear();
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
Interval(N);
