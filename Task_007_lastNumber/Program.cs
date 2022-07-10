/*Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.*/

Console.WriteLine("Введите целое трехзначное цисло: ");
int num = Convert.ToInt32(Console.ReadLine());
int lastNumber = 0;
lastNumber = num % 10;
Console.WriteLine($"Последняя цифра данного трехзначного числа {lastNumber}");