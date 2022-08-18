// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
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

int[] FindIndexesMinElement(int[,] matrix2D)
{
    int min = matrix2D[0, 0];
    int[] coordinate = new int[2];
    for (int i = 0; i < matrix2D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2D.GetLength(1); j++)
        {
            if (matrix2D[i, j] < min)
            {
                min = matrix2D[i, j];
                coordinate[0] = i;
                coordinate[1] = j;
            }
        }
    }
    Console.WriteLine($"Минимальное значение элемента: {min} --> на пересечении {coordinate[0] + 1} строки, {coordinate[1] + 1} столбца");
    return coordinate;
}

int[,] RemoveRowColumn(int[,] matrix2D, int[] arrayCoordinate)
{
    int row = 0;
    int column = 0;
    int[,] matrixRemovedRowColumn = new int[matrix2D.GetLength(0) - 1,
                                            matrix2D.GetLength(1) - 1];
    for (int i = 0; i < matrixRemovedRowColumn.GetLength(0); i++)
    {
        if (row == arrayCoordinate[0]) row++;
        for (int j = 0; j < matrixRemovedRowColumn.GetLength(1); j++)
        {
            if (column == arrayCoordinate[1]) column++;
            matrixRemovedRowColumn[i, j] = matrix2D[row, column];
            column++;
        }
        column = 0;
        row++;
    }
    return matrixRemovedRowColumn;
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
string[] matrixMinMaxString = GetUserInputNumbersString("Введите границы интервала случайных чисел (через запятую): ");
CheckUserInputToInt(matrixMinMaxString);
int[] matrixMinMaxInt = ConvertUserInputNumbersInt(matrixMinMaxString);
int[,] matrix = new int[matrixSizeInt[0], matrixSizeInt[1]];
FillMatrix2DInt(matrix, matrixMinMaxInt[0], matrixMinMaxInt[1]);
PrintMatrix2DInt(matrix, "Исходный массив: ");
Console.WriteLine();
int[] indexes = FindIndexesMinElement(matrix);
Console.WriteLine();
int[,] matrixRemoved = RemoveRowColumn(matrix, indexes);
PrintMatrix2DInt(matrixRemoved, "Массив с удаленными строкой и столбцом содеращих минимальное значение элемента: ");
