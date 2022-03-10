// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("Введите X1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z1: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("Введите X2: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z2: ");
int z1 = Convert.ToInt32(Console.ReadLine());

int c = (((a-a1) * (a-a1)) + ((b-b1) * (b-b1)) + ((z-z1) * (z-z1)));
int i = Convert.ToInt32(Math.Sqrt(c));

Console.WriteLine(i);