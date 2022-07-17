// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//!Математическое решение для чисел, не окончивающися нулем/нулями.
// Условию задачи является ли число палиндромом - удовлетворяет
// 100, 64540, 9000, 100000 - не являются палиндромами
// Единственный баг - в отображении подобных чисел, нули впереверку опускаются

int IsPalindrome(int n)
{
    int n2 = 0;
    int nDiv = n;
    int lastDigital = 0;

    while (nDiv > 0)
    {
        lastDigital = nDiv % 10;
        nDiv = nDiv / 10;
        n2 = n2 * 10 + lastDigital;
    }
    return n2;
}

void OutputResult(int number, int number2)
{
    if (number == number2)
        Console.WriteLine($"Число {number} является палиндромом, так если прочесть его с конца, получится {number2}");
    else if (number < 0)
        Console.WriteLine($"Число {number} не является палиндромом, так если прочесть его с конца, получится {number * -1}-, знак минус после числа. Палиндром не математическое понятие.");
    else
        Console.WriteLine($"Число {number} не является палиндромом, так если прочесть его с конца, получится {number2}");
}

Console.Clear();
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = IsPalindrome(num);
OutputResult(num, num2);

