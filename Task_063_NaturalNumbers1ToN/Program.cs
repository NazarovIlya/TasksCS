// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int GetUserInputInt(string userInputString)
{
    Console.WriteLine(userInputString);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void NaturalNumber(int number)
{
    if (number == 0) return;
    NaturalNumber(number - 1);
    Console.Write($"{number} ");
}

int num = GetUserInputInt("Введите натуральное число: ");
Console.WriteLine("Натуральные числа от 1 до N: ");
NaturalNumber(num);
