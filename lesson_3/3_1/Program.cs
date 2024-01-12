// Задайте массиив. Напишите программу, которая определяет, 
//  присутствует ли заданное число в массиве. Программа
//  должна выдавать ответ: Да/нет.

Console.WriteLine("Введите значение");
int a = int.Parse(Console.ReadLine()!);
int[] arr = { 1, 2, 3, 4, 5 };
int i = 0;
bool found = false;


while (i < arr.Length)
{
    if (a == arr[i])
    {
        found = true;
        break;
    }
    i++;
}

if (found)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}