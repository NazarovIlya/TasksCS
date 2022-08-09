// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] GetUserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    string[] str = Console.ReadLine().Split(",");
    int[] array = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        array[i] = Convert.ToInt32(str[i]);
    }
    return array;
}

// int GetCountNumbersOverNull(int[] array)
// {
//     int countNumbersOverNull = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (arrayp[i] > 0) countNumbersOverNull++;
//     }
//     return countNumbersOverNull;
// }

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
int[] numM = GetUserInputInt("Введите число: ");
PrintArray(numM, "");