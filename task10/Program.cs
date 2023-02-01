// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
int secondNumber = (number % 100) / 10;
//secondNumber = secondNumber / 10;
Console.WriteLine($"{number} -> {secondNumber}");
