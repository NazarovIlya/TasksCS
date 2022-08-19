// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int GetAckermanFunction(int argM, int argN)
{
    if (argM < 0 && argN < 0)
        return -1;    // Функция Аккермана имеет решение только для положительных значений аргументов");
    if (argM == 0)
        return argN + 1;
    if (argM > 0 && argN == 0)
        return GetAckermanFunction(argM - 1, 1);
    //if (argM > 0 && argN > 0) 
    return GetAckermanFunction(argM - 1, GetAckermanFunction(argM, argN - 1));
}

int result = GetAckermanFunction(4, 4);
Console.WriteLine($"{result}");