// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число, которое необходимо возвести в с некоторую степень: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите сетепнь, в которую необходимо возвести {N}: ");
int degree = Convert.ToInt32(Console.ReadLine());

void FindNumberInSomeDegree(int numMax, int D)
{

    int num = 1;
    int result = 0;
    while (num <= numMax)
    {
        int i = 0;
        while (i < D)
        {
            result = num * num;
            i++;
        }
        Console.WriteLine($"{N} -->  {num} | {result}   |");
        num++;
    }
}

FindNumberInSomeDegree(N, degree);