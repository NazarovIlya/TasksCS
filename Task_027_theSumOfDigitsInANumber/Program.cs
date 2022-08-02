// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число, сумму цифр которого хотите узнать: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int number)
{
    int digit = 0;
    int sum = 0;
    for (int i = 0; number > 0 || number < 0; i++)
    {
        digit = number % 10;
        sum += digit;
        number = number / 10;
    }
    return sum;
}

void PrintResult(int result)
{
    Console.WriteLine($"Сумма цифр в числе {result}");
}

int res = 0;
if (num > 0) res = SumOfDigits(num);
else if (num < 0) res = SumOfDigits(num);
PrintResult(res);

