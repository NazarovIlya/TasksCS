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

void FillSpiralMatrix2DInt(int[,] matrix2D, int number, int summand)
{
    int nRows = matrix2D.GetLength(0) - 1;
    int nColumns = matrix2D.GetLength(1) - 1;
    int length = 0;
    if (nRows < nColumns) length = nRows;
    length = nColumns;
    for (int i = 0; i < length; i++)
    {
        for (int j = i; j < nColumns; j++)
        {
            matrix2D[i, j] = number;
            number += summand;
        }
        for (int k = i; k < nRows; k++)
        {
            matrix2D[k, nColumns] = number;
            number += summand;
        }
        for (int l = nColumns; l > i; l--)
        {
            matrix2D[nRows, l] = number;
            number += summand;
        }
        for (int m = nRows; m > i; m--)
        {
            matrix2D[m, i] = number;
            number += summand;
        }
        nRows--;
        nColumns--;
        if (length % 2 == 0)
            matrix2D[nRows / 2 + 1, nColumns / 2 + 1] = number;
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

//Console.Clear();
string[] matrixSizeString = GetUserInputNumbersString("Введите размер матриц (n строк,n столбцов): ");
matrixSizeString = CheckUserInputToInt(matrixSizeString);
int[] matrixSizeInt = ConvertUserInputNumbersInt(matrixSizeString);
string[] minNumberNSummandString = GetUserInputNumbersString("Введите минимальное значение числа первого элемента массива и значение числа, на которое будет увеличиваться первое: ");
minNumberNSummandString = CheckUserInputToInt(minNumberNSummandString);
int[] minNumberNSummandInt = ConvertUserInputNumbersInt(minNumberNSummandString);
int[,] matrixSpiral = new int[matrixSizeInt[0], matrixSizeInt[1]];
FillSpiralMatrix2DInt(matrixSpiral, minNumberNSummandInt[0], minNumberNSummandInt[1]);
PrintMatrix2DInt(matrixSpiral, string.Empty);