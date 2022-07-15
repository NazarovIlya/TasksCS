// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void TableCubes(int numMax)
{
    int num = 1;
    while (num <= numMax)
    {
        Console.WriteLine($"{N} --> | {num} | {num * num * num}   |");
        num++;
    }
}

TableCubes(N);