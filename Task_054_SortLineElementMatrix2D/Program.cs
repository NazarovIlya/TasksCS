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
        if (stringArray[i] == "" || Convert.ToInt32(stringArray[i]) == null)
        {
            Console.WriteLine("Ошибка ввода данных.");
            break;
        }
        numberArray[i] = Convert.ToInt32(stringArray[i]);
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






//Console.Clear();
int[] matrixSize = GetUserInputNumbersInt("Введите размер матрицы (n строк,n столбцов): ");
int[,] matrixMinMax = GetUserInputNumbersInt("Введите границы интервала случайных чисел (через запятую): ");
int[,] matrixToSort = new int[matrixMinMax[0], matrixMinMax[1]];
FillMatrix2DInt(matrixToSort);