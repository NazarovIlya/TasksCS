// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] FillArray(int arrayLength, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int GetArrayLength(int[] array)
{
    int arrayLength = 0;
    if (array.Length % 2 == 0)
        return arrayLength = array.Length / 2;
    else return arrayLength = array.Length / 2 + 1;
}

int[] GetProductArrayPair(int[] array, int arrayLength)
{
    int[] newArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        newArray[i] = array[i] * array[array.Length - i - 1];
    }
    return newArray;
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
int num = UserInputInt("Введите количество элементов массива: ");
int[] arr = FillArray(num, -100, 100);
int arrLength = GetArrayLength(arr);
int[] productArr = GetProductArrayPair(arr, arrLength);
PrintArray(arr, "Задан массив: ");
PrintArray(productArr, "Произведения пар крайних чисел массива: ");
