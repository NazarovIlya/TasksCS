// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetUserInputInt(string userInputString)
{
    Console.WriteLine(userInputString);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetOrder(int numberOrder)
{
    int resOrder = 1;
    for (int i = 0; i < numberOrder; i++)
    {
        resOrder = resOrder * 10;
    }
    return resOrder;
}

void FillMatrixTwoDimensionalDouble(double[,] matrixTwoDimensional, int orderValue)
{
    Random random = new Random();
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {
            double result = random.NextDouble() * numberOrder;
            matrixTwoDimensional[i, j] = result;
        }

    }
}

void PrintMatrixTwoDimensional(double[,] matrixTwoDimensional)
{
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {
            if (matrixTwoDimensional[i, j] >= 0)
                Console.Write($" {matrixTwoDimensional[i, j]} ");
            else Console.Write($"{matrixTwoDimensional[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int nRows = GetUserInputInt("Введите количество строк массива: ");
int nColumns = GetUserInputInt("Введите количество столбцов массива: ");
int minValue = GetUserInputInt("Введите значение нижней границы Random-интервала: ");
int maxValue = GetUserInputInt("Введите значение верхней границы Random-интервала: ");
int order = GetUserInputInt("Введите максимальный порядок чисел массива: ");
double[,] matrix = new double[nRows, nColumns];
int orderValue = GetOrder();
FillMatrixTwoDimensionalDouble(matrix, orderValue, minValue, maxValue);
PrintMatrixTwoDimensional(matrix);
