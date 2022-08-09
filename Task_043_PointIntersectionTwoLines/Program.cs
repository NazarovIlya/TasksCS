// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Для y = ax + c и y = bx + d      
// a b - угловые коэфициенты, c и d - пересечения прямых с осью y
// используем
// x = (d - c) / (a - b)
// y = a*((d - c) / (a - b) + c) = (ad - bc) / (a - b)

//! k1 = a, b1 = c; k2 = b, b2 = d

int GetUserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void CheckLineIntersection(int angularK1, int intersectionY1, int angularK2, int intersectionY2)
{
    if ((angularK1 == angularK2) && (intersectionY1 == intersectionY2))
        Console.WriteLine("Прямые совпадают.");
    else if ((angularK1 == angularK2) && (intersectionY1 != intersectionY2))
        Console.WriteLine("Прямые параллельны.");
    else
        Console.WriteLine("Прямые пересекаются.");
}

double[] FindIntersectionPoint(int angularK1, int intersectionY1, int angularK2, int intersectionY2)
{
    double x = Convert.ToDouble((intersectionY2 - intersectionY1)) / Convert.ToDouble((angularK1 - angularK2));
    double y = Convert.ToDouble((angularK1 * intersectionY2) - Convert.ToDouble(angularK2 * intersectionY1)) / (angularK1 - angularK2);
    double[] coordArr = new double[2];
    coordArr[0] = x;
    coordArr[1] = y;
    return coordArr;
}

void PrintResult(double[] array)
{
    Console.WriteLine($"Координаты точки пересечения: {array[0]}, {array[1]}");
}


Console.Clear();
int numA = GetUserInputInt("Введите угловой коэфициент для первой функции: ");
int numC = GetUserInputInt("Введите точку пересечения с осью y для первой функции: ");
int numB = GetUserInputInt("Введите угловой коэфициент для второй функции: ");
int numD = GetUserInputInt("Введите точку пересечения с осью y для второй функции: ");
CheckLineIntersection(numA, numC, numB, numD);
double[] coord = FindIntersectionPoint(numA, numC, numB, numD);
PrintResult(coord);