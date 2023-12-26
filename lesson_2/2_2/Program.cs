//2. Напишите программу, которая принимает на вход трехзначное
//   число и возводит вторую цифру этого числа в степень, равную 
//   третьей цифре.

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()!);
if (num >= 100 && num <= 1000)
{
    int num1 = num % 100 / 10;
    int num2 = num % 10;
    double result = Math.Pow(num1, num2);
    Console.WriteLine(result);
}
else
{
    if (num < 100 || num > 1000)
        Console.WriteLine("Вы ввели не трехзначное число");
}

// Решение в 3 строки:
// Concole.Wtite("Введите трехзначнеое число);
// int num = int.Parse(Console.ReadLine()!);
// Console.Write(Math.Pow(num / 10 % 10, num % 10));