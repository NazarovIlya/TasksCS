// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Clear();

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] arr = new int[8];
FillArray(arr);
Console.WriteLine("Задан массив из 8 чисел случайным образом:");
PrintArray(arr);
