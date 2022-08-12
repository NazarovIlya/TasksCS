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
    for (int i = 0; i < matrixTwoDimension.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrixTwoDimension.GetLength(0); j++)
        {
            sum += matrixTwoDimension[j, i];
            arraySum[i] = sum;
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

void PrintSumArray(int[] array, string preOutputText, string postOutputText)
{
    Console.WriteLine(preOutputText);
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($" {array[i]}  | ");
        else Console.Write($"{array[i]} | ");
    }
    Console.WriteLine(postOutputText);
}

Console.Clear();
int[] RowColum = GetUserInputNumbersInt("Введите количество строк и столбцов массива через запятую: ");
int[] arrayIntervalMinMax = GetUserInputNumbersInt("Введите интервал значений массива: ");
int[,] matrix = new int[RowColum[0], RowColum[1]];
Console.WriteLine();    // an empty line to separate the output of blocks of results
FillMatrixTwoDimensionalInt(matrix, arrayIntervalMinMax[0], arrayIntervalMinMax[1]);
PrintMatrixTwoDimensional(matrix);
int[] sumArray = GetSumColumnNumbersArray(matrix);
Console.WriteLine();    // an empty line to separate the output of blocks of results
PrintSumArray(sumArray, "Сумма чисел в каждом столбце массива: ", "");
