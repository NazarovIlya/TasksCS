// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void SortLineElementsMatrix2D(int[,] matrix2D)
{
    int minValue = matrix2D[0, 0];
    for (int i = 0; i < matrix2D.GetLength(0); i++)
    {
        int minPosI = i;
        for (int j = 0; j < matrix2D.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix2D.GetLength(1); k++)
            {
                if (matrix2D[i, j] < matrix2D[i, k]) continue;
                int temp = matrix2D[i, j];
                matrix2D[i, j] = matrix2D[i, k];
                matrix2D[i, k] = temp;
            }
        }
    }
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
int[] matrixSize = GetUserInputNumbersInt("Введите размер матрицы (n строк,n столбцов): ");
int[] matrixMinMax = GetUserInputNumbersInt("Введите границы интервала случайных чисел (через запятую): ");
int[,] matrixToSort = new int[matrixSize[0], matrixSize[1]];
FillMatrix2DInt(matrixToSort, matrixMinMax[0], matrixMinMax[1]);
PrintMatrix2DInt(matrixToSort, "Исходный массив: ");
SortLineElementsMatrix2D(matrixToSort);
PrintMatrix2DInt(matrixToSort, "Массив после сортировки: ");