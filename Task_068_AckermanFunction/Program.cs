// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

string[] GetUserInputNumbersString(string userInputTextString)
{
    Console.WriteLine(userInputTextString);
    string[] userInputString = Console.ReadLine().Split(",");
    return userInputString;
}

void CheckUserInputToInt(string[] userInputString)
{
    for (int i = 0; i < userInputString.Length; i++)
    {
        if (userInputString[i] == string.Empty || userInputString[i] == " "
            || Convert.ToInt32(userInputString[i]) == null
            || userInputString.Length < 2)
        {
            Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
            Environment.Exit(0);
        }
    }
}

int[] ConvertUserInputNumbersInt(string[] userNumberString)
{
    int[] userNumberInt = new int[userNumberString.Length];
    for (int i = 0; i < userNumberString.Length; i++)
    {
        userNumberInt[i] = Convert.ToInt32(userNumberString[i]);
    }
    return userNumberInt;
}

int GetAckermanFunction(int argM, int argN)
{
    if (argM < 0 && argN < 0)
        return -1;    // Функция Аккермана имеет решение только для положительных значений аргументов");
    if (argM == 0)
        return argN + 1;
    if (argM > 0 && argN == 0)
        return GetAckermanFunction(argM - 1, 1);
    //if (argM > 0 && argN > 0) 
    return GetAckermanFunction(argM - 1, GetAckermanFunction(argM, argN - 1));
}

int result = GetAckermanFunction(4, 4);
Console.WriteLine($"{result}");