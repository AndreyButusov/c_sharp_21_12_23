// Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа

Console.WriteLine("Введите двузначное число из отрезка [10, 99]");
int num = int.Parse(Console.ReadLine()!);

if (num < 10 || num > 99)
    Console.WriteLine("Введено число вне указанного диапазона");
else
    {
        if (num / 10 == num % 10)
            Console.WriteLine("Первая и вторая цифра введенного числа равны");
        else
        {
            if (num / 10 > num % 10)
                Console.WriteLine(num / 10);
            else
                Console.WriteLine(num % 10);
        }
    }
