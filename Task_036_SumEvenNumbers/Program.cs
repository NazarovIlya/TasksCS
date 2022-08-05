// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int arrayLength)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

int GetSumEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
            sum += array[i];
    }
    return sum;
}

void PrintSumEven(int[] array, int result)
{
    Console.Write("В массиве: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}] ");
    }
    Console.WriteLine($"сумма элементов, стоящих на нечётных позициях --> {result}");
}
int[] arr = FillArray(num);
int res = GetSumEven(arr);
PrintSumEven(arr, res);