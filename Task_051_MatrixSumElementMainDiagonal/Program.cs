// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[] GetUserInputNumbersInt(string userInputNumberString)
{
    Console.WriteLine(userInputNumberString);
    string[] stringArray = Console.ReadLine().Split(",");
    int[] numberArray = new int[stringArray.Length];
    for (int i = 0; i < numberArray.Length; i++)
    {
        if (stringArray[i] == "" || stringArray[i] == " "
            || Convert.ToInt32(stringArray[i]) == null)
        {
            Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
            Environment.Exit(0);
        }
        else numberArray[i] = Convert.ToInt32(stringArray[i]);
    }
    return numberArray;
}

int[,] FillMatrixTwoDimension(int[,] matrix, int min, int max)
{
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
int GetMatrixSumElementMainDiagonal(int[,] matrixTwoDimensional)
{
    int sum = 0;
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {
            if (i == j)
                sum += matrixTwoDimensional[i, j];
        }
    }
    return sum;
}
int GetMatrixSumElementMainDiagonalOptimized(int[,] matrixTwoDimensional)
{
    int sum = 0;
    int length = 0;
    if (matrixTwoDimensional.GetLength(0) <= matrixTwoDimensional.GetLength(1))
        length = matrixTwoDimensional.GetLength(0);
    else
        length = matrixTwoDimensional.GetLength(1);
    for (int i = 0; i < length; i++)
    {
        sum += matrixTwoDimensional[i, i];
    }
    return sum;
}

void PrintMatrixTwoDimensional(int[,] matrixTwoDimensional, string userOutputString)
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
int[] matrixSize = GetUserInputNumbersInt("Введите количество строк и столбцов массива через запятую: ");
int[] matrixMinMax = GetUserInputNumbersInt("Введите границы интервала случайных чисел: ");
int[,] matrixSumRowColumn = new int[matrixSize[0], matrixSize[1]];
FillMatrixTwoDimension(matrixSumRowColumn, matrixMinMax[0], matrixMinMax[1]);
PrintMatrixTwoDimensional(matrixSumRowColumn, "Исходная матрица: ");
int result = GetMatrixSumElementMainDiagonal(matrixSumRowColumn);
Console.WriteLine($"Сумма элементов массива по главной диагонали {result}");
int resultOpt = GetMatrixSumElementMainDiagonalOptimized(matrixSumRowColumn);
Console.WriteLine($"Сумма элементов массива по главной диагонали (оптимизированный алгоритм): {resultOpt}");


