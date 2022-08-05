// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

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

void PrintResult(double[] array, double result)
{
    Console.Write("В массиве: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]} , ");
        else Console.Write($"{array[i]}] ");
    }
    Console.Write($"разница между максимальным и минимальным значением элемента массива состовляет {result}");

}

double[] arr = FillArray(num);
double minimum = GetMin(arr);
double maximum = GetMax(arr);
double res = GetDiscrepancy(minimum, maximum);
PrintResult(arr, res);
