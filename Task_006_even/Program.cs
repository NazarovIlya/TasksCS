/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).*/
Console.Clear();
Console.WriteLine("Введите целое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine($"Число {number} является четным.");
} else
{
    Console.WriteLine($"Число {number} не является четным.");
}