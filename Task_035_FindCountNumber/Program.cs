// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] FillArrayRandom(int arrayLength, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int CheckCountNumber(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
            count++;
    }
    return count;
}

void PrintArray(int[] array, string outputText)
{
    Console.WriteLine(outputText);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}] ");
    }
}


Console.Clear();
int size = UserInputInt("Введите колчество элементов массива: ");
int[] arr = FillArrayRandom(size, 10, 200);
int res = CheckCountNumber(arr, 10, 99);
PrintArray(arr, "Задан массив: ");
Console.WriteLine($"Чисел в интервале от 10 до 99: {res}");