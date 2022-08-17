// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

string[] GetUserInputNumbersString(string userInputTextString)
{
    Console.WriteLine(userInputTextString);
    string[] userInputString = Console.ReadLine().Split(",");
    return userInputString;
}

void CheckUserInputToInt(string[] userInputString)
{
    for (int i = 0; i < userInputString.Length; i++)
    {
        if (userInputString[i] == string.Empty || userInputString[i] == " "
            || Convert.ToInt32(userInputString[i]) == null
            || userInputString.Length < 2)
        {
            Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
            Environment.Exit(0);
        }
    }
}

int[] ConvertUserInputNumbersInt(string[] userNumberString)
{
    int[] userNumberInt = new int[userNumberString.Length];
    for (int i = 0; i < userNumberString.Length; i++)
    {
        userNumberInt[i] = Convert.ToInt32(userNumberString[i]);
    }
    return userNumberInt;
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
string[] matrixSizeString = GetUserInputNumbersString("Введите количество строк и столбцов массива через запятую: ");
CheckUserInputToInt(matrixSizeString);
int[] matrixSizeInt = ConvertUserInputNumbersInt(matrixSizeString);
string[] matrixMinMaxString = GetUserInputNumbersString("Введите границы интервала случайных чисел (через запятую): ");
CheckUserInputToInt(matrixMinMaxString);
int[] matrixMinMaxInt = ConvertUserInputNumbersInt(matrixMinMaxString);
int[,] matrix = new int[matrixSizeInt[0], matrixSizeInt[1]];
FillMatrix2DInt(matrix, matrixMinMaxInt[0], matrixMinMaxInt[1]);
PrintMatrix2DInt(matrix, "Задан массив: ");
int result = GetMinSumLineMatrix2D(matrix);
Console.WriteLine($"Наименьшая сумма значений всех элементов в {result} строке (машинное исчисление от нуля).");