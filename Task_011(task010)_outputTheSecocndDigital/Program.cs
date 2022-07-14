// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
// Способ ввода данных на выбор:
Console.WriteLine("Введите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = new Random().Next(90, 1000);

int SecondDigital(int number)
{
    int firstTwo = number / 10;
    int res = firstTwo % 10;
    return res;
}

int result = SecondDigital(num);
if (result == 0 || (num < 100 && num > -100) || (num > 999 || num < -1000))
    Console.WriteLine("Вы ввели недопустимое значение.");
else
    Console.WriteLine($"{num} --> {result}");