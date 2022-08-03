// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumberLength(int number)
{
    int count = 0;
    for (int i = 1; number > 0; i++)
    {
        number = number / 10;
        count = i;
    }
    return count;
}

void PrintNumberLength(int number, int numberLength)
{
    Console.WriteLine($"Количество цифр в числе {number} --> {numberLength}");
}

int res = NumberLength(num);
PrintNumberLength(num, res);
