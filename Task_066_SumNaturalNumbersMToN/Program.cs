// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetSumNaturalNumbersmToN(int m, int n)
{
    int sum = m;
    if (m >= n) return sum;
    return sum += GetSumNaturalNumbersmToN(++m, n);
}


//Console.Clear();
int sum = GetSumNaturalNumbersmToN(4, 8);
Console.WriteLine($"{sum}");