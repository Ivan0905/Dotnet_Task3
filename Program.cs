// Домашнее задание №3

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine()!);
double y1 = Convert.ToDouble(Console.ReadLine()!);
double z1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine()!);
double y2 = Convert.ToDouble(Console.ReadLine()!);
double z2 = Convert.ToDouble(Console.ReadLine()!);

double len = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+Math.Pow ((z2-z1),2));

Console.WriteLine($"Расстояние между точками равняется {len:f3}");