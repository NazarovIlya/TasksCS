// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

string[] GetUserInputNumbersString(string userInputTextString)
{
    Console.WriteLine(userInputTextString);
    string[] userInputString = Console.ReadLine().Split(",");
    return userInputString;
}

string[] CheckUserInputToInt(string[] userInputString)
{
    for (int i = 0; i < userInputString.Length; i++)
    {
        if (userInputString[i] == string.Empty || userInputString[i] == " "
            || Convert.ToInt32(userInputString[i]) == null)
        {
            Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
            Environment.Exit(0);
        }
    }
    return userInputString;
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

void FillMatrix3DInt(int[,,] matrix3D, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                // matrix3D[i, j, k] = random.Next(min, max);
            }
        }
    }
}

void PrintMatrix3DInt(int[,,] matrix3D, string userOutputString)
{
    Console.WriteLine(userOutputString);
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            Console.Write("[");
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                if (matrix3D[i, j, k] >= 0)
                    Console.Write($" {matrix3D[i, j, k]} ({i}, {j}, {k}) ");
                else Console.Write($"{matrix3D[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}


//Console.Clear();
string[] matrixSizeString = GetUserInputNumbersString("Введите размер массива (три значения через запятую): ");
matrixSizeString = CheckUserInputToInt(matrixSizeString);
int[] matrixSizeInt = ConvertUserInputNumbersInt(matrixSizeString);
string[] intervalMinMaxString = GetUserInputNumbersString("Введите границы интервала случайных чисел: ");
intervalMinMaxString = CheckUserInputToInt(intervalMinMaxString);
int[] intervalMinMaxInt = ConvertUserInputNumbersInt(intervalMinMaxString);
int[,,] matrix3D = new int[matrixSizeInt[0], matrixSizeInt[1], matrixSizeInt[2]];
FillMatrix3DInt(matrix3D, intervalMinMaxInt[0], intervalMinMaxInt[1]);
PrintMatrix3DInt(matrix3D, "Полученный массив: ");
