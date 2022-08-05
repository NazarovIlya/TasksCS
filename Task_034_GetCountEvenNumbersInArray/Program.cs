// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество трехзначных чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(num);
int res = GetCountEvenNumbers(arr);
PrintResult(arr, res);

int[] FillArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    Random rnd = new Random();
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int GetCountEvenNumbers(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            evenCount++;
    }
    return evenCount;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.Write("] ");
}

void PrintResult(int[] array, int result)
{
    Console.Write("В массиве: ");
    PrintArray(arr);
    if (result == 1)
        Console.Write($"находится {result} нечетная позиция");
    else if (result > 1 && result < 5 || (result % 10) > 1 && (result % 10) > 5)
        Console.Write($"находится {result} нечетных позиции");
    else Console.Write($"находится {result} нечетных позиций");
}


