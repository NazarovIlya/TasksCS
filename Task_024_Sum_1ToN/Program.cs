// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.WriteLine("Введите число: ");
int nA = Convert.ToInt32(Console.ReadLine());

int Sum1ToN(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

//void PrintSum(int)

int result = Sum1ToN(nA);
Console.WriteLine($"Сумма {result}");