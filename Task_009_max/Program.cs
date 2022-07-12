// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
Console.Clear();


int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit == secondDigit)
    {
        return 0;
    }
    if (firstDigit > secondDigit)
    {
        return firstDigit;
    }
    else
    {
        return secondDigit;
    }
}

int num = new Random().Next(10, 100);
int maxDigit = MaxDigit(num);
if (maxDigit == 0) Console.WriteLine($"{num} --> Цифры одинаковые");
else
    Console.WriteLine($"{num} --> {maxDigit}");