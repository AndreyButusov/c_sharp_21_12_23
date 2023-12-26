// 4.  Напишите программу, которая выводит третью с конца
//     цифру заданного числа или сообщает, что третьей цифры
//     нет.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
if (num >= 100)
    Console.WriteLine(num / 100 % 10);
else
    Console.WriteLine("Третьей цифры нет");