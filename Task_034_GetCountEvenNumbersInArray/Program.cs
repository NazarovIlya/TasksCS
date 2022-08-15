// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        if (array[i] % 2 == 0)
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
    PrintArray(array);
    if (result == 1)
        Console.Write($"находится {result} четное число");
    else if (result > 1 && result < 5 || (result % 10) > 1 && (result % 10) > 5)
        Console.Write($"находится {result} четных числа");
    else Console.Write($"находится {result} четных чисел");
}


Console.WriteLine("Введите количество трехзначных чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
int res = GetCountEvenNumbers(array);
PrintResult(array, res);
