//  Задача 3. Считать строку с консоли, содержащую латинские
//  буквы. Вывести на экран согласные буквы этой строки.
//  !!! Использовать рекурсию. Не использовать цикл.

Console.Clear();

void NoVowels(string str, int index = 0)
{
    string consonants = "bcdfghjklmnpqrstvwxz";
    if (str.Length == index)
        return;
    if (consonants.Contains(char.ToLower(str[index])))
        Console.Write(str[index]);
    NoVowels(str, index + 1);    
}

Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
NoVowels(str);