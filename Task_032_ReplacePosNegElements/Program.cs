// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ArrayNegative(int[] array, int size)
{
    int[] arrayNegative = new int[size];
    for (int i = 0; i < arrayNegative.Length; i++)
    {
        arrayNegative[i] = array[i] * (-1);
    }
    return arrayNegative;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}] ");
    }

}

int[] arr = FillArrayRandom(6, -10, 11);
int[] newArr = ArrayNegative(arr, arr.Length);
PrintArray(arr);
PrintArray(newArr);