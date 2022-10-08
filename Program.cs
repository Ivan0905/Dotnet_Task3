// Домашнее задание №3

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