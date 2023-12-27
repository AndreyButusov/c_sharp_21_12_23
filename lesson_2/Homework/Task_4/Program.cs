// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число");
int N = int.Parse(Console.ReadLine()!);
string str1 = "";
while (N > 0)
{
    if (str1 == "")
    {
        str1 = str1 + N % 10;
        N = N / 10;
    }
    else
    {
        str1 = N % 10 + ", " + str1;
        N = N / 10;
    }
}
Console.Write(str1);
