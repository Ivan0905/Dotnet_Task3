// Домашнее задание №3

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write($"Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

while ((num<10000)||(num>99999))
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
}
