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

double GetUserInputDouble(string userInputStr)
{
    Console.WriteLine(userInputStr);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double[] FindIntersectionPoint(double angularK1, double intersectionY1, double angularK2, double intersectionY2)
{
    double x = (intersectionY2 - intersectionY1) / (angularK1 - angularK2);
    double y = ((angularK1 * intersectionY2) - (angularK2 * intersectionY1)) / (angularK1 - angularK2);
    double[] coordArr = new double[2];
    coordArr[0] = Math.Round(x, 2);
    coordArr[1] = Math.Round(y, 2);
    return coordArr;
}

void CheckLineIntersection(double angularK1, double intersectionY1, double angularK2, double intersectionY2, double[] arrayCoord)
{
    if ((angularK1 == angularK2) && (intersectionY1 == intersectionY2))
        Console.WriteLine("Прямые совпадают.");
    else if ((angularK1 == angularK2) && (intersectionY1 != intersectionY2))
        Console.WriteLine("Прямые параллельны.");
    else
    {
        Console.WriteLine("Прямые пересекаются.");
        Console.WriteLine($"Координаты точки пересечения: {arrayCoord[0]}, {arrayCoord[1]}");
    }
}

Console.Clear();
double numA = GetUserInputDouble("Введите угловой коэфициент для первой функции: ");
double numC = GetUserInputDouble("Введите точку пересечения с осью y для первой функции: ");
double numB = GetUserInputDouble("Введите угловой коэфициент для второй функции: ");
double numD = GetUserInputDouble("Введите точку пересечения с осью y для второй функции: ");
double[] coord = FindIntersectionPoint(numA, numC, numB, numD);
CheckLineIntersection(numA, numC, numB, numD, coord);
