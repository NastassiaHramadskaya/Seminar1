//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = numberA * (-1);
int i = 0;
int min = 0;
int max = 0;
if (numberA > numberB)
{
    min = numberB;
    max = numberA;
    i = min;
}
else
{
    min = numberA;
    max = numberB;
    i = min;
}
while (i <= max)
{   
Console.Write($"{i}, ");
 i++;
}