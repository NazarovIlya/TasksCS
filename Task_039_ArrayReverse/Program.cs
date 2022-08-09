// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int GetUserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArrayRandom(int arrayLength, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void ArrayReverse(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
        index1++;
        index2--;
    }
}

void PrintArray(int[] array, string preOutputText, string postOutputText)
{
    Console.Write($"{preOutputText}");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}] ");
    }
    Console.Write(postOutputText);
}

Console.Clear();
int arrLength = GetUserInputInt("Введите длину массива: ");
int minArr = GetUserInputInt("Введите нижнюю границу интервала: ");
int maxArr = GetUserInputInt("Введите верхнюю границу интервала: ");
int[] arr = CreateArrayRandom(arrLength, minArr, maxArr);
PrintArray(arr, "Исходный массив ", "");
ArrayReverse(arr);
PrintArray(arr, "Тот же массив после реверса: ", "");