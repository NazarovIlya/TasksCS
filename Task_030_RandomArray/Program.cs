// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


Console.Clear();
Console.WriteLine("Введите число: ");
int nA = Convert.ToInt32(Console.ReadLine());
int[] GetRandomArray(int arrayLength)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (array.Length != array.Length - 1)
            Console.Write(',');
    }
    Console.Write(']');
}

int[] arr = GetRandomArray(nA);
PrintArray(arr);
