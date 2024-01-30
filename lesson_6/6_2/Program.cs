//  Задача 2. На основе символов строки (тип string) сформировать
//  массив символов (тип char[]). Вывести массив на экран.

//  Метод строки ToCharArray() не использовать.

Console.Clear();
string str = "Hello";
char[] CharToArr(string word)
{
    char[] arr = new char[word.Length];
    for(int i = 0; i < word.Length; i++)
    {
        arr[i] = word[i];
    }
return arr;
}

Console.WriteLine($"[{string.Join(", ", CharToArr(str))}]");