//  Задача 4. Задайте строку, состоящую из слов, разделенных пробелами. 
//  Сформировать строку, в которой слова расположены в обратном порядке. 
//  В полученной строке слова должны быть также разделены пробелами.

using System.Text;

Console.Clear();

string[] ReverseStr(string[] str)         //Функция разворота массива
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        (str[i], str[str.Length - i - 1]) = (str[str.Length - i - 1], str[i]);
    }
    return str;
}

Console.WriteLine("Введите предложение");
Console.InputEncoding = Encoding.Unicode;
string InputStr = Console.ReadLine()!;
string[] words = InputStr.Split(' ');       // создаем из заданного текста массив слов
string[] ReverseWords = ReverseStr(words);
Console.WriteLine($"{String.Join(" ", ReverseWords)}");