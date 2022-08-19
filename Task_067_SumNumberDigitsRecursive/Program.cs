// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int GetUserInputInt(string userInputString)
{
    Console.WriteLine(userInputString);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetSumDigits(int number, int sum)
{
    if (number == 0) return sum;
    sum += number % 10;
    return GetSumDigits(number / 10, sum);
}


//Console.Clear();
int num = GetUserInputInt("Введите число больше 9: ");
int result = GetSumDigits(num, 0);
Console.WriteLine($"Сумма всех цифр в числе: {num} --> {result}.");