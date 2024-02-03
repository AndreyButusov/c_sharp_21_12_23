//  Задача 3. Задайте произвольную строку. Выясните, является ли она палиндромом.


using System.Text;

Console.Clear();

bool IsStrPalindrom(string str)
{
    char[] chars = str.ToCharArray();
    
    for (int i = 0; i < chars.Length / 2; i++)
    {
        if (chars[i] != chars[chars.Length - i - 1])
            return false;
    }
    return true;
}

Console.WriteLine("Введите произвольную строку");
Console.InputEncoding = Encoding.Unicode;
string str = Console.ReadLine()!;
if (IsStrPalindrom(str))
    Console.WriteLine("Введен палиндром");
else
    Console.WriteLine("Введен не палиндром");