// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный порядок чисел: ");
int ord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество знаков после запятой: ");
int signsAfter = Convert.ToInt32(Console.ReadLine());

double[] FillArray(int arrayLength, int order, int signsAfterDot)
{
    double res = 0;
    Random rnd = new Random();
    double[] array = new double[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        res = rnd.NextDouble() * order;
        array[i] = Math.Round(res, signsAfterDot);
    }
    return array;
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

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double GetDiscrepancy(double min, double max)
{
    double discrepancy = 0;
    discrepancy = max - min;
    return discrepancy;
}

void PrintResult(double[] array, double result, int sign)
{
    Console.Write("В массиве: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}] ");
    }
    result = Math.Round(result, sign);
    Console.WriteLine($"разница между максимальным и минимальным значением элемента массива состовляет {result}");
}

int resOrder = GetOrder(ord);
double[] arr = FillArray(num, resOrder, signsAfter);
double minimum = GetMin(arr);
double maximum = GetMax(arr);
double res = GetDiscrepancy(minimum, maximum);
PrintResult(arr, res, signsAfter);
