// Задача 57.
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// 25 мин
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза



void FillMatrix2DInt(int[,] matrixTwoDimensional,
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

int[] ConversionArray(int[,] matrix)
{
    int[] arraySort = new int[matrix.Length];
    int m = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arraySort[m] = matrix[i, j];
            m++;
        }
    }
    Array.Sort(arraySort);
    return arraySort;
}

void OutputCountNumbersToConsole(int[] array)
{
    int number = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else
        {
            Console.WriteLine($"Число {number} встречается --> {count} раз");
            number = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
            Console.WriteLine($"Число {number} встречается --> {count} раз");
    }
}

void PrintArray(int[] array, string preOutputText, string postOutputText)
{
    Console.Write(preOutputText);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}] ");
    }
    Console.WriteLine(postOutputText);
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



//Console.Clear();

int[,] matrix = new int[3, 3];
FillMatrix2DInt(matrix, 1, 20);
PrintMatrix2DInt(matrix, String.Empty);
int[] array = ConversionArray(matrix);
PrintArray(array, String.Empty, String.Empty);
OutputCountNumbersToConsole(array);

