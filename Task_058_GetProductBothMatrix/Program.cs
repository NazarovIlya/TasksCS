// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

void CheckMatrixSizes(int firstMatrix2DLength, int secondMatrix2DLength)
{
    if (firstMatrix2DLength != secondMatrix2DLength)
    {
        Console.WriteLine("Матрицы с такими размерами перемножать нельзя, так как количество столбцов первой не равно количеству строк второй.");
        Environment.Exit(0);
    }
    else Console.WriteLine("Матрицы могут быть перемножены.");
}

int[,] GetProductBothMatrix2D(int[,] firstMatrix2D, int[,] secondMatrix2D)
{
    int[,] productMatrix = new int[firstMatrix2D.GetLength(0), secondMatrix2D.GetLength(1)];
    for (int i = 0; i < firstMatrix2D.GetLength(0); i++)
    {
        int sumProduct = 0;
        for (int j = 0; j < secondMatrix2D.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix2D.GetLength(0); k++)
            {
                sumProduct = firstMatrix2D[i, k] * secondMatrix2D[k, j];
                productMatrix[i, j] += sumProduct;
            }
        }
    }
    return productMatrix;
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
string[] firstMatrixSizeString = GetUserInputNumbersString("Введите количество строк и столбцов массива через запятую: ");
CheckUserInputToInt(firstMatrixSizeString);
int[] firstMatrixSizeInt = ConvertUserInputNumbersInt(firstMatrixSizeString);
string[] secondMatrixSizeString = GetUserInputNumbersString("Введите количество строк и столбцов массива через запятую: ");
CheckUserInputToInt(secondMatrixSizeString);
int[] secondMatrixSizeInt = ConvertUserInputNumbersInt(secondMatrixSizeString);
CheckMatrixSizes(firstMatrixSizeInt[1], secondMatrixSizeInt[0]);
string[] firsrtMatrixMinMaxString = GetUserInputNumbersString("Введите границы интервала случайных чисел (через запятую) для первой матрицы: ");
CheckUserInputToInt(firsrtMatrixMinMaxString);
int[] firstMatrixMinMaxInt = ConvertUserInputNumbersInt(firsrtMatrixMinMaxString);
string[] secondMatrixMinMaxString = GetUserInputNumbersString("Введите границы интервала случайных чисел (через запятую) для второй матрицы: ");
CheckUserInputToInt(secondMatrixMinMaxString);
int[] secondMatrixMinMaxInt = ConvertUserInputNumbersInt(secondMatrixMinMaxString);
int[,] firstMatrix = new int[firstMatrixSizeInt[0], firstMatrixSizeInt[1]];
int[,] secondMatrix = new int[secondMatrixSizeInt[0], secondMatrixSizeInt[1]];
FillMatrix2DInt(firstMatrix, firstMatrixMinMaxInt[0], firstMatrixMinMaxInt[1]);
FillMatrix2DInt(secondMatrix, secondMatrixMinMaxInt[0], secondMatrixMinMaxInt[1]);
int[,] resultMatrix = GetProductBothMatrix2D(firstMatrix, secondMatrix);
PrintMatrix2DInt(firstMatrix, "Первый массив: ");
PrintMatrix2DInt(secondMatrix, "Второй массив: ");
PrintMatrix2DInt(resultMatrix, "Произведение матриц: ");