Console.WriteLine("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= c; i++)
{
    Console.Write($"{i}: {i * i}");
    Console.WriteLine();
}