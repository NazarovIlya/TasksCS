// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Для y = ax + c и y = bx + d      
// a b - угловые коэфициенты, c и d - пересечения прямых с осью y
// используем
// x = (d - c) / (a - b)
// y = a*((d - c) / (a - b) + c) (ad - bc) / (a - b)

//! k1 = a, b1 = c; k2 = b, b2 = d

int GetUserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


Console.Clear();
int numB1 = GetUserInputInt();
int numK1 = GetUserInputInt();
int numB2 = GetUserInputInt();
int numK2 = GetUserInputInt();
