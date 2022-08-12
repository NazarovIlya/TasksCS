// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FillMatrixTwoDimensionalInt(int[,] matrixTwoDimensional,
                                int minIntervalValue, int maxIntervalValue)
{
    Random randomDouble = new Random();
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {
            matrixTwoDimensional[i, j] = randomDouble.Next(minIntervalValue, maxIntervalValue);
        }
    }
}

int[] GetSumColumnNumbersArray(int[,] matrixTwoDimension)
{
    int[] arraySum = new int[matrixTwoDimension.GetLength(1)];
    for (int i = 0; i < matrixTwoDimension.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrixTwoDimension.GetLength(1); j++)
        {
            sum += matrixTwoDimension[i, j];
            arraySum[j] = sum;
        }
    }
    return arraySum;
}

void PrintMatrixTwoDimensional(int[,] matrixTwoDimensional)
{
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {
            if (matrixTwoDimensional[i, j] >= 0)
                Console.Write($" {matrixTwoDimensional[i, j]}    ");
            else Console.Write($"{matrixTwoDimensional[i, j]}    ");
        }
        Console.WriteLine();
    }
}


// TO DO: Console.Clear();
int[] RowColum = GetUserInputNumbersInt("Введите количество строк и столбцов массива через запятую: ");
int[] arrayIntervalMinMax = GetUserInputNumbersInt("Введите интервал значений массива: ");
int[,] matrix = new int[RowColum[0], RowColum[1]];
FillMatrixTwoDimensionalInt(matrix, arrayIntervalMinMax[0], arrayIntervalMinMax[1]);
PrintMatrixTwoDimensional(matrix);
int[] sumArray = GetSumColumnNumbersArray(matrix);
Console.Write(sumArray);
