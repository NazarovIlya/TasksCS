// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
void GetMatrixSquearsElement(int[,] matrixTwoDimensional)
{
    Random random = new Random();
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                matrixTwoDimensional[i, j] *= matrixTwoDimensional[i, j];
        }
    }
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


//Console.Clear();
int[] matrixSize = GetUserInputNumbersInt("Введите количество строк и столбцов массива через запятую: ");
int[] matrixMinMax = GetUserInputNumbersInt("Введите границы интервала случайных чисел: ");
int[,] matrixProductRowColumn = new int[matrixSize[0], matrixSize[1]];
FillMatrixTwoDimension(matrixProductRowColumn, matrixMinMax[0], matrixMinMax[1]);
PrintMatrixTwoDimensional(matrixProductRowColumn, "Исходная матрица: ");
GetMatrixSquearsElement(matrixProductRowColumn);
PrintMatrixTwoDimensional(matrixProductRowColumn, "Матирца содержащая квадратичные значения четных элементов исходного массива: ");
