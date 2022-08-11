﻿// Задача 47. Задайте двумерный массив размером m×n,
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

int GetOrder(int orderValue)
{
    int resOrder = 1;
    for (int i = 0; i < orderValue; i++)
    {
        resOrder = resOrder * 10;
    }
    return resOrder;
}

void FillMatrixTwoDimensionalDouble(double[,] matrixTwoDimensional,
                                    int orderValue, int signsAfterDot)
{
    Random random = new Random();
    Random randomNumberModule = new Random();
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {
            int module = randomNumberModule.Next(0, 2);
            double result = random.NextDouble() * orderValue;
            if (module == 0)
                matrixTwoDimensional[i, j] = Math.Round(result, signsAfterDot);
            else matrixTwoDimensional[i, j] = Math.Round(-result, signsAfterDot);
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
int order = GetUserInputInt("Введите основной порядок чисел массива: ");
int signs = GetUserInputInt("Введите желаемую точность числа: ");
double[,] matrix = new double[nRows, nColumns];
int orderValue = GetOrder(order);
FillMatrixTwoDimensionalDouble(matrix, orderValue, signs);
PrintMatrixTwoDimensional(matrix);