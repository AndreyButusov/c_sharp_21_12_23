// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

Console.WriteLine("Введите координату X точки");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки");
int Y = int.Parse(Console.ReadLine()!);

if (X == 0 || Y == 0)
    Console.WriteLine("Точка находится на координатной плоскости");
else
    {
        if (X > 0 && Y > 0)
            Console.WriteLine("Точка находится в I четверти");
        if (X < 0 && Y > 0)
            Console.WriteLine("Точка находится в II четверти");
        if (X < 0 && Y < 0)
            Console.WriteLine("Точка находится в III четверти");
        if (X > 0 && Y < 0)
            Console.WriteLine("Точка находится в IV четверти");
    }
