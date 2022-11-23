// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("День недели - понедельник");
}
if (number == 2)
{
    Console.WriteLine("День недели - вторник");
}
if (number == 3)
{
    Console.WriteLine("День недели - среда");
}
if (number == 4)
{
    Console.WriteLine("День недели - четверг");
}
if (number == 5)
{
    Console.WriteLine("День недели - пятница");
}
if (number == 6)
{
    Console.WriteLine("День недели - суббота");
}
if (number == 7)
{
    Console.WriteLine("День недели - воскресенье");
}
if (number > 7)
{
    Console.WriteLine("Дня недели с таким номером нет.");
}
