// Задача 20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D

Console.WriteLine("Введите координаты первой точки: ");
Console.WriteLine("Введите X1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.WriteLine("Введите X2: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
int b1 = Convert.ToInt32(Console.ReadLine());

int c = (((a-a1) * (a-a1)) + ((b-b1) * (b-b1)));
int i = Convert.ToInt32(Math.Sqrt(c));

Console.WriteLine(i);





// int X = Convert.ToInt32(new Random().Next(1, 100));
// int Y = Convert.ToInt32(new Random().Next(-100, -1));

// if (chet == 1)
// {
//     Console.WriteLine($"Случайные точки х = {X}, y = {X}");
// }
// if (chet == 2)
// {
//     Console.WriteLine($"Случайные точки x = {Y} , y = {X}");
// }
// if (chet == 3)
// {
//     Console.WriteLine($"Случайные точки x = {Y} , y = {Y}");
// }
// if (chet == 4)
// {
//     Console.WriteLine($"Случайные точки x = {X} , y = {Y}");
// }
