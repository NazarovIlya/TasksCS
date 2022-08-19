// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void GetSumNaturalNumbersmToN(int m, int n)
{
    int sum = 0;
    if (m > n) Console.WriteLine("Число M должно быть меньше числа N.");
    else
        for (int i = m; i < n; i++)
        {
            sum += m;
        }
    m++;
    Console.WriteLine($"{sum}");
}

GetSumNaturalNumbersmToN(1, 15);