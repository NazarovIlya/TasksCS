/*Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.*/

Console.WriteLine("Введите целое число от 1 до N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;

if(N == 1)
{
    Console.WriteLine("В данном интервале четных чисел нет");
} else 
if(N < i)
{
    Console.WriteLine("Введеное Вами число не соответствует запросу, так как меньше единицы.");
} else

Console.Write($"В интервале от 1 до {N} четными являются: ");
while(i <= N)
{
    Console.Write($"{i} ");
    i = i + 2;
}
