// 2. Напишите программу, которая на вход принимает одно число
//    "N", а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Enter a number N: ");
int N = int.Parse(Console.ReadLine()!);
int count = -N;
while (count <= N)
{
    Console.Write(count + " ");
    count++;
}