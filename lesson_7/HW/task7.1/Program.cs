//    Задача 1. Задайте значения M и N. Напишите программу, 
//  которая выведет все натуральные числа в промежутке от M до N. 
//  Использовать рекурсию, не использовать циклы.

Console.Clear();

void Interval(int StartValue, int StopValue)
{
    if (StartValue - 1 == StopValue)
        return;
    Interval(StartValue, StopValue - 1);
    Console.WriteLine(StopValue);
}

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
if (M > N)
    (M, N) = (N, M);
Interval(M, N);