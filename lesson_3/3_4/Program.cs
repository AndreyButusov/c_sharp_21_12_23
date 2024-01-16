Console.WriteLine("Введите трехзначное число");
int Num = int.Parse(Console.ReadLine()!);

if (Num < 100 || Num > 999)
{
    Console.WriteLine("Введено не трехзначное число");
}
else
{
int size = 3;
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    arr[i] = Num % 10;
    Num = Num / 10;
    Console.Write($"{arr[i]} ");
}
}
