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

int[] GetUserInputNumbersInt(string userInputNumberString)
{
    Console.WriteLine(userInputNumberString);
    string[] stringArray = Console.ReadLine().Split(",");
    int[] numberArray = new int[stringArray.Length];
    for (int i = 0; i < numberArray.Length; i++)
    {
        if (stringArray[i] == string.Empty || stringArray[i] == " "
            || Convert.ToInt32(stringArray[i]) == null)
        {
            Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
            Environment.Exit(0);
        }
        else numberArray[i] = Convert.ToInt32(stringArray[i]);
    }
    return numberArray;
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

int[,] GetProductBothMatrix2D(int[,] firstMatrix2D, int[,] secondMatrix2D)
{
    int[,] productMatrix = new int[firstMatrix2D.GetLength(0), firstMatrix2D.GetLength(1)];
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            productMatrix[i, j] = firstMatrix2D[i, j] * secondMatrix2D[i, j];
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


//Console.Clear();
int[] matrixSize = GetUserInputNumbersInt("Введите размер матриц (n строк,n столбцов): ");
int[] firsrtMatrixMinMax = GetUserInputNumbersInt("Введите границы интервала случайных чисел (через запятую) для первой матрицы: ");
int[] secondMatrixMinMax = GetUserInputNumbersInt("Введите границы интервала случайных чисел (через запятую) для второй матрицы: ");
int[,] firstMatrix = new int[matrixSize[0], matrixSize[1]];
int[,] secondMatrix = new int[matrixSize[0], matrixSize[1]];
FillMatrix2DInt(firstMatrix, firsrtMatrixMinMax[0], secondMatrixMinMax[1]);
FillMatrix2DInt(secondMatrix, secondMatrixMinMax[0], secondMatrixMinMax[1]);
int[,] resultMatrix = GetProductBothMatrix2D(firstMatrix, secondMatrix);
PrintMatrix2DInt(firstMatrix, "Первый массив: ");
PrintMatrix2DInt(secondMatrix, "Второй массив: ");
PrintMatrix2DInt(resultMatrix, "Произведение матриц: ");