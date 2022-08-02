// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.WriteLine("Введите число: ");
int nA = Convert.ToInt32(Console.ReadLine());

int Composition(int number)
{
    int composition = 1;
    for (int i = 1; i <= number; i++)
    {
        composition = composition * i;
    }
    return composition;
}

int result = Composition(nA);
Console.WriteLine($"Произведение всех чисел от 1 до {nA} --> {result}");
