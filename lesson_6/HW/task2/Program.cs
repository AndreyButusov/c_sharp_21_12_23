//  Задача 2. Задайте строку, содержащую латинские буквы в обоих регистрах. 
//  Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.Clear();

string RandomStr(int VolumeStr)        //Функция создания произвольной строки заданной длины
{
    string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string str = "";
    Random rnd = new Random();
    for (int i = 0; i < VolumeStr; i++)
    {
        str += abc[rnd.Next(0, abc.Length - 1)];
    }
    return str;
}

Console.Write("Количество символов в строке: ");
int VolumeStr = int.Parse(Console.ReadLine()!);
Console.Write("Сформированная строка: ");
string str = RandomStr(VolumeStr);
Console.WriteLine(str);
Console.Write("Немного магии: ");
Console.WriteLine(str.ToUpper());
