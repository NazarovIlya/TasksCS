// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int GetMinSumLineMatrix2D(int[,] matrix2D)
{
    int line = 0;
    int[] sumArray = new int[matrix2D.GetLength(0)];
    for (int i = 0; i < matrix2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix2D.GetLength(1); j++)
        {
            sum += matrix2D[i, j];
        }
        sumArray[i] = sum;
        for (int k = 0; k < sumArray.Length; k++)
        {
            if (sumArray[i] < sumArray[k]) line = i;
        }
    }
    return line;
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
int[,] matrix = new int[matrixSize[0], matrixSize[1]];
FillMatrix2DInt(matrix, matrixMinMax[0], matrixMinMax[1]);
PrintMatrix2DInt(matrix, "Задан массив: ");
int result = GetMinSumLineMatrix2D(matrix);
Console.WriteLine($"Наименьшая сумма значений всех элементов в {result} строке (машинное исчисление от нуля).");