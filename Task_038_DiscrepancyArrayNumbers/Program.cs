// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Hello, World!");
int num = Convert.ToInt32(ReadLine());

double[] FillArray(int arrayLength)
{
    Random rnd = new Random();
    double[] array = new double[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

double GetMin(double[] array)
{
    double min = array[i];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double GetMax(double[] array)
{
    double max = array[i];
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
}

double[] arr = FillArray(num);
double minimum = GetMin(arr);
double maximum = GetMax(arr);
result = GetDiscrepancy(min, max);
Console.WriteLine($"Разница между максимальным и минимальным значением элемента массива состовляет {result}");
