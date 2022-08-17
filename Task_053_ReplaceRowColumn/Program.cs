// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void FillMatrix2DInt(int[,] matrixTwoDimensional,
                                int minIntervalValue, int maxIntervalValue)
{
    Random random = new Random();
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {
            matrixTwoDimensional[i, j] = random.Next(minIntervalValue, maxIntervalValue);
        }
    }
}

void ReplaceRows(int[,] matrixTwoDimensional, int firstRow, int lastRow)
{
    firstRow = firstRow - 1;
    lastRow = lastRow - 1;
    int temp = 0;
    for (int i = 0; i < matrixTwoDimensional.GetLength(1); i++)
    {
        temp = matrixTwoDimensional[lastRow, i];
        matrixTwoDimensional[lastRow, i] = matrixTwoDimensional[firstRow, i];
        matrixTwoDimensional[firstRow, i] = temp;
    }

}

void PrintMatrix2DInt(int[,] matrixTwoDimensional, string userOutputString)
{
    Console.WriteLine(userOutputString);
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {
            if (matrixTwoDimensional[i, j] >= 0)
                Console.Write($" {matrixTwoDimensional[i, j]} ");
            else Console.Write($"{matrixTwoDimensional[i, j]} ");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}


Console.Clear();
string[] matrixSizeString = GetUserInputNumbersString("Введите количество строк и столбцов массива через запятую: ");
CheckUserInputToInt(matrixSizeString);
int[] matrixSizeInt = ConvertUserInputNumbersInt(matrixSizeString);
string[] matrixMinMaxString = GetUserInputNumbersString("Введите интервал значений массива через запятую: ");
CheckUserInputToInt(matrixMinMaxString);
int[] matrixMinMaxInt = ConvertUserInputNumbersInt(matrixMinMaxString);
int[,] matrix2D = new int[matrixSizeInt[0], matrixSizeInt[1]];
string[] numberRowString = GetUserInputNumbersString("Введите номера строк, значения которых необходимо поменять местами");
CheckUserInputToInt(numberRowString);
int[] numberRowInt = ConvertUserInputNumbersInt(numberRowString);
FillMatrix2DInt(matrix2D, matrixMinMaxInt[0], matrixMinMaxInt[1]);
PrintMatrix2DInt(matrix2D, "Исходный массив: ");
ReplaceRows(matrix2D, numberRowInt[0], numberRowInt[1]);
PrintMatrix2DInt(matrix2D, "Масссив после замены строк: ");