// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// Console.WriteLine("");
// int num = Convert.ToInt32(ReadLine());

Console.Clear();
int[] FillArrayRandom(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int[] GetSumPositiveNegativeElements(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPos += array[i];
        else if (array[i] < 0) sumNeg += array[i];
    }
    return new int[] { sumPos, sumNeg };
}

void PrintArray(int[] array, int[] summ)
{
    Console.Write("В массиве: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}] ");
    }
    Console.Write($"суммы положительных и отрицательных цифр: {summ[0]}, {summ[1]}");
}

int[] arr = FillArrayRandom(12, -9, 9);
int[] sumPosNeg = GetSumPositiveNegativeElements(arr);
PrintArray(arr, sumPosNeg);
