// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.Clear();
Console.Write("Введите трезначное число: ");
int numberA = int.Parse(Console.ReadLine());
int div = numberA % 10;
Console.WriteLine($"Последняя цифра числа {numberA} - {div}");