//  Задача 1. Задайте массив символов (тип char[]). Создайте стоку
//  из символов этого массива.

char[] mass = {'a', 'b', 'c', 'd'};
string result = "";
foreach (char i in mass)
{
    result += i;
}
Console.WriteLine(result);