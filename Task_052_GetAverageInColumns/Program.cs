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

void FillMatrixTwoDimensionalInt(int[,] matrixTwoDimensional,
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

double[] GetAverageColumnNumbersArray(int[,] matrixTwoDimension, int signsAfterDot)
{
    double[] arrayAverage = new double[matrixTwoDimension.GetLength(1)];
    for (int i = 0; i < matrixTwoDimension.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrixTwoDimension.GetLength(0); j++)
        {
            sum += matrixTwoDimension[j, i];
        }
        double average = sum / matrixTwoDimension.GetLength(1);
        arrayAverage[i] = Math.Round(average, signsAfterDot);
    }
    return arrayAverage;
}

void PrintMatrixTwoDimensional(int[,] matrixTwoDimensional)
{
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {

            if (matrixTwoDimensional[i, j] >= 0)
                Console.Write($" {matrixTwoDimensional[i, j]}   ");
            else Console.Write($"{matrixTwoDimensional[i, j]}   ");
            //Console.Write("]");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void PrintAverageArray(double[] array, string preOutputText, string postOutputText)
{
    Console.WriteLine(preOutputText);
    Console.Write($"|| ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]};  ");
        else Console.Write($"{array[i]} ||");
    }
    Console.WriteLine(postOutputText);
}

Console.Clear();
int[] RowColum = GetUserInputNumbersInt("Введите количество строк и столбцов массива через запятую: ");
int[] arrayIntervalMinMax = GetUserInputNumbersInt("Введите интервал значений массива через запятую: ");
int[,] matrix = new int[RowColum[0], RowColum[1]];
Console.WriteLine();    // an empty line to separate the output of blocks of results
FillMatrixTwoDimensionalInt(matrix, arrayIntervalMinMax[0], arrayIntervalMinMax[1]);
PrintMatrixTwoDimensional(matrix);
double[] averageArray = GetAverageColumnNumbersArray(matrix, 2);
Console.WriteLine();    // an empty line to separate the output of blocks of results
PrintAverageArray(averageArray, "Среднее арифметическое всех чисел в каждом столбце массива: ", "");
