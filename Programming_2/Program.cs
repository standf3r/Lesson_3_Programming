// Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int chet = Convert.ToInt32(Console.ReadLine());

int X = Convert.ToInt32(new Random().Next(1, 100));
int Y = Convert.ToInt32(new Random().Next(-100, -1));

if (chet == 1)
{
    Console.WriteLine($"Случайные точки х = {X}, y = {X}");
}
if (chet == 2)
{
    Console.WriteLine($"Случайные точки x = {Y} , y = {X}");
}
if (chet == 3)
{
    Console.WriteLine($"Случайные точки x = {Y} , y = {Y}");
}
if (chet == 4)
{
    Console.WriteLine($"Случайные точки x = {X} , y = {Y}");
}


