// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""



void NaturalNumbersNToM(int m, int n)
{
    if (m > n) Console.WriteLine("Число M должно быть меньше числа N.");
    else
        for (int i = m; i <= n; i++)
        {
            Console.Write($"{m} ");
            m++;
        }
}

NaturalNumbersNToM(4, 3);