// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

void FillMatrix2DInt(int[,] matrix, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max);
        }
    }
}

void CheckMatrixSizes(int rows, int columns)
{
    if (rows != columns)
    {
        Console.WriteLine("Замена значений строк на значения столбцов невозможна, так как матрица не является квадратной.");
        Environment.Exit(0);
    }
}

void ReplaceRowsColumns(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[j, i] = matrix[i, j];
            matrix[j, i] = temp;
        }
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
string[] matrixMinMaxString = GetUserInputNumbersString("Введите границы интервала случайных чисел (через запятую): ");
CheckUserInputToInt(matrixMinMaxString);
int[] matrixMinMaxInt = ConvertUserInputNumbersInt(matrixMinMaxString);
int[,] matrix2D = new int[matrixSizeInt[0], matrixSizeInt[1]];
CheckMatrixSizes(matrix2D.GetLength(0), matrix2D.GetLength(1));
PrintMatrix2DInt(matrix2D, "");
FillMatrix2DInt(matrix2D, matrixMinMaxInt[0], matrixMinMaxInt[1]);
PrintMatrix2DInt(matrix2D, "");
ReplaceRowsColumns(matrix2D);
PrintMatrix2DInt(matrix2D, "");