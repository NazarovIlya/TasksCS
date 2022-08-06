// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

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

bool CheckNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
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

void PrintResult(bool result)
{
    if (result == true) Console.WriteLine("yes");
    else Console.WriteLine("no");
}

Console.Clear();
int num = UserInputInt("Введите число: ");
int[] arr = FillArrayRandom(20, 10, 100);
bool res = CheckNumber(arr, num);
PrintArray(arr, "Задан массив: ");
PrintResult(res);

