//  Задача 1: Напишите программу, которая бесконечно запрашивает 
//  целые числа с консоли. Программа завершается при вводе символа 
//  ‘q’ или при вводе числа, сумма цифр которого чётная.

/*
int Sum(int num)    //функция для подсчета суммы цифр во введенном числе
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

Console.WriteLine("Введите целое число");
string str = Console.ReadLine()!;
while (str != "q" && Sum(int.Parse(str)) % 2 != 0)
{
    Console.WriteLine("Введите целое число");
    str = Console.ReadLine()!;

}
if (str == "q")
Console.WriteLine("Пользователь вышел принудительно!");
else
Console.WriteLine($"Ввод окончен! Сумма цифр в числе {int.Parse(str)} равна {Sum(int.Parse(str))}");
*/

void InfEnter()
{
    string word;

    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine()!;

        if (word != "q")
        {
            int count = 0;
            int number = int.Parse(word);
            for (; number > 0; number /= 10)
                count += number % 10;
            if (count % 2 == 0)
            {
                Console.WriteLine("Game is over! Number is even");
                return;
            }
        }
        else
            return;
    }
}

InfEnter();