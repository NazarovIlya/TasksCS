// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArrayRandomInt(int arrayLength, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < copyArray.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return array;
}

void PrintArray(int[] array, string preOutputText, string postOutputText)
{
    Console.Write($"{preOutputText}");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}] ");
    }
    Console.WriteLine(postOutputText);
}

Console.Clear();
int num = UserInputInt("Введите длину массива: ");
int min = UserInputInt("Введите нижнюю границу интервала: ");
int max = UserInputInt("Введите верхнюю границу интервала: ");
int[] arr = CreateArrayRandomInt(num, min, max);
int[] copyArr = CopyArray(arr);
PrintArray(arr, "Исходный массив: ", "");
PrintArray(copyArr, "Скопированный массив: ", "");