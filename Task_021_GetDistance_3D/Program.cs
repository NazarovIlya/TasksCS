// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.Clear();
Console.WriteLine("Введите координату x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double GetPoDistance3D(int xa, int ya, int xb, int yb, int za, int zb)
{
    return Math.Round(Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya) + (zb - za) * (zb - za))), 2, MidpointRounding.ToZero);
}
double result = GetPoDistance3D(x1, y1, x2, y2, z1, z2);
Console.WriteLine(result);

