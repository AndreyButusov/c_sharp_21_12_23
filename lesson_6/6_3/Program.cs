//  Задача 3. Считать строку с консоли, состоящую из латинских
//  букв в нижнем регистре. Выяснить, сколько среди введенных
//  букв гласных.4

Console.Clear();
string str = Console.ReadLine()!;
int FindVowel(string word)
{
    string vowels = "aeiou";
    int value = 0;
    for (int i = 0; i < word.Length; i++)
    {
        if (vowels.Contains(word[i]))
            value++;
    }
    return value;
}
Console.WriteLine(FindVowel(str));