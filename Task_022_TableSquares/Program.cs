// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void TableSquares(int numMax)
{
    int num = 1;
    while (num <= numMax)
    {
        Console.WriteLine($"{N} --> | {num} | {num * num}   |");
        num++;
    }
}

TableSquares(N);
