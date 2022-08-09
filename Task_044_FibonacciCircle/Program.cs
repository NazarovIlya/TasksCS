// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Fibonacci(int number)
{
    int f = 0;
    int f1 = 1;
    int f2 = 1;
    Console.Write($"{f}, {f1}, {f2}, ");
    for (int i = 0; i <= number; i++)
    {
        f = f1 + f2;
        Console.Write($"{f}");
        if (i < number) Console.Write(", ");
        f2 = f1;
        f1 = f;
    }
}

Console.Clear();
int num = UserInputInt("Введите количество чисел: ");
Fibonacci(num);