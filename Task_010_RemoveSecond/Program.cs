// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);

int RemoveSecond(int num)
{
    int first = num / 100;
    int third = num % 10;
    return first * 10 + third;
}
int result = RemoveSecond(num);
Console.WriteLine($"{num} --> {result}");

