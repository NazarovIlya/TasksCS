// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Clear();

void FillArray(int[] array)
{
    Random rnd = new Random();
    int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 1000);
    }

}

void PrintArray(int[] array)
{
    Console.WriteLine($"Задан массив из {array.Length} чисел случайным образом:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);
