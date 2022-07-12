// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool IsSquare(int a, int b)
{
    return a * a == b || b * b == a;
}

Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(num1, num2);

if (result)
{
    Console.WriteLine($"{num1}, {num2} -> yes");
}
else
{
    Console.WriteLine($"{num1}, {num2} -> no");
}