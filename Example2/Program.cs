// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
int squareB = numberB * numberB;
if (numberA == squareB)
{
    Console.WriteLine($"Квадрат числа {numberB} равен {numberA}");
}
else
{
    Console.WriteLine($"Квадрат числа {numberB} не равен {numberA}");
}
