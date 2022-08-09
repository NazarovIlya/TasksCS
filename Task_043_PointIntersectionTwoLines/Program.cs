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

int[] CheckLineIntersection(int angularK1, int intersectionY1, int angularK2, int intersectionY2)
{

}


Console.Clear();
int numA = GetUserInputInt("Введите угловой коэфициент для первой функции: ");
int numC = GetUserInputInt("Введите точку пересечения с осью y для первой функции: ");
int numB = GetUserInputInt("Введите угловой коэфициент для первой функции: ");
int numВ = GetUserInputInt("Введите точку пересечения с осью y для второй функции: ");
