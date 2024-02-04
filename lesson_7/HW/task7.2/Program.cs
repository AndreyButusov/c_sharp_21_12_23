//  Задача 2. Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int Akkerman(int m, int n)
{
    if (m == 0) 
        return n + 1;
    if (n == 0) 
        return Akkerman(m - 1, 1);
    else 
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Введите неотрицательное число m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите неотрицательное число n");
int n = int.Parse(Console.ReadLine()!);

int ResultAkkerman = Akkerman(m, n);
Console.Write($"Значение функции Аккермана = {ResultAkkerman} ");
