// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите значение точки А по оси X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение точки А по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение точки А по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение точки B по оси X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение точки B по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

// корень ((х2-х1)^2 + (у2-у1)^2+(z2-z1)^2)

var result = Math.Sqrt(Math.Pow(x2 - x1, 2)+Math.Pow(y2 - y1, 2)+Math.Pow(z2 - z1, 2));

Console.Write($"Расстояние между точками А и В равно: {Math.Round(result, 2)}");