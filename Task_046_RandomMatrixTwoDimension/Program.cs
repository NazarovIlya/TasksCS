// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[] GetUserInputNumbersInt(string userInputNumberString)
{
    Console.WriteLine(userInputNumberString);
    string[] stringArray = Console.ReadLine().Split(",");
    int[] numberArray = new int[stringArray.Length];
    for (int i = 0; i < numberArray.Length; i++)
    {
        numberArray[i] = Convert.ToInt32(stringArray[i]);
    }
    return numberArray;
}


int[,] CreateMatrixTwoDimension(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrixTwoDimensional(int[,] matrixTwoDimensional)
{
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
int[] matrixSize = GetUserInputNumbersInt("Введити колчество строк и столбцов массива через запятую");
int[] intervalMinMax = GetUserInputNumbersInt("Введите границы интервала случайных чисел через запятую");
int[,] matrix = CreateMatrixTwoDimension(matrixSize[0], matrixSize[1], intervalMinMax[0], intervalMinMax[1]);
PrintMatrixTwoDimensional(matrix);