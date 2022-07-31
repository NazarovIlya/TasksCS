// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Число А в натуральной степени В.");
Console.WriteLine("Введите число А, возводимое в степень число: ");
int nA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В - степень в которую необходимо возвести: ");
int nB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int number, int degree)
{
    int exponentiationNumber = number;
    for (int i = 1; i < degree; i++)
    {
        exponentiationNumber = exponentiationNumber * nA;
    }
    return exponentiationNumber;
}

int result = Exponentiation(nA, nB);
Console.WriteLine($"Число {nA} в натуральной степени {nB} дает число {result}");