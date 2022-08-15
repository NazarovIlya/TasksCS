// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

string[] GetUserInputNumbersString(string userInputTextString)
{
    Console.WriteLine(userInputTextString);
    string[] userInputString = Console.ReadLine().Split(",");
    return userInputString;
}

string[] CheckUserInputToInt(string[] userInputString)
{
    for (int i = 0; i < userInputString.Length; i++)
    {
        if (userInputString[i] == string.Empty || userInputString[i] == " "
            || Convert.ToInt32(userInputString[i]) == null)
        {
            Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
            Environment.Exit(0);
        }
    }
    return userInputString;
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





//Console.Clear();
string[] matrixSizeString = GetUserInputNumbersString("Введите размер матриц (n строк,n столбцов): ");
matrixSizeString = CheckUserInputToInt(matrixSizeString);
int[] matrixSizeInt = ConvertUserInputNumbersInt(matrixSizeString);
string[] intervalMinMaxString = GetUserInputNumbersString("Введите границы интервала случайных чисел: ");
intervalMinMaxString = CheckUserInputToInt(intervalMinMaxString);
int[] intervalMinMaxInt = ConvertUserInputNumbersInt(intervalMinMaxString);
