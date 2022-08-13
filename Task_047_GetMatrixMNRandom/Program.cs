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
int[] nRowsColumns = GetUserInputNumbersInt("Введите количество строк и столбцов массива через запятую: ");
//int nColumns = GetUserInputInt("Введите количество  массива: ");
int order = GetUserInputInt("Введите основной порядок чисел массива: ");
int signs = GetUserInputInt("Введите желаемую точность числа: ");
double[,] matrix = new double[nRowsColumns[0], nRowsColumns[1]];
int orderValue = GetOrder(order);
FillMatrixTwoDimensionalDouble(matrix, orderValue, signs);
PrintMatrixTwoDimensional(matrix);
