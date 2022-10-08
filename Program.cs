// Домашнее задание №3

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*Console.Write($"Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

while ((num < 10000) || (num > 99999))
{
    Console.Write($"Введено не пятизначное число. Введите повторно: ");
    num = int.Parse(Console.ReadLine()!);
}
int num1 = num / 10000;
int num2 = num % 10000 / 1000;
int num4 = num % 100 / 10;
int num5 = num % 10;

if ((num1 == num5) && (num2 == num4))
{
    Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    Console.WriteLine($"Число {num}  НЕ является палиндромом");
}*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
/*
Console.WriteLine("Введите координаты первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine()!);
double y1 = Convert.ToDouble(Console.ReadLine()!);
double z1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine()!);
double y2 = Convert.ToDouble(Console.ReadLine()!);
double z2 = Convert.ToDouble(Console.ReadLine()!);

double len = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine($"Расстояние между точками равняется {len:f3}");*/


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int x1 = int.Parse(Console.ReadLine()!);
int i = 0;
int result = 0;
while (i <= x1)
{

    result = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine($"{i}^3 = {result}");
    i++;
}
