﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

string[] GetUserInputNumberString(string userInputNumberString)
{
    Console.WriteLine(userInputNumberString);
    string[] strArray = Console.ReadLine().Split(",");
    return strArray;
}

int[] ConvertArrayStrToInt(string[] stringArray)
{
    int[] array = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        array[i] = Convert.ToInt32(stringArray[i]);
    }
    return array;
}

int GetCountNumbersOverNull(int[] array)
{
    int countNumbersOverNull = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) countNumbersOverNull++;
    }
    return countNumbersOverNull;
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
    Console.Write(postOutputText);
}


Console.Clear();
string[] stringNumM = GetUserInputNumberString("Введите числа, разделяя их запятой: ");
int[] numM = ConvertArrayStrToInt(stringNumM);
int countPosNumM = GetCountNumbersOverNull(numM);
PrintArray(numM, "Получившейся массив: ", $"содержит {numM.Length} элементов, из которых {countPosNumM} положительных");