/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).*/

Console.WriteLine("Введите целое натуральное число: ");
int bigNumber = Convert.ToInt32(Console.ReadLine());

int even = 2;
while(even <= bigNumber)
{
    Console.Write($"{even} ");
    even = even + 2;
}