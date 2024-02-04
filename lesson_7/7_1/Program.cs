//  Задача 1. Напишите программу, которая будет принимать на
//  вход число и возвращает сумму его цифр. Использовать рекурсию.

int sum(int num)
{
    if (num == 0)
        return 0;
    return sum(num / 10) + num % 10;
}

Console.Clear();
Console.WriteLine(sum(1234));