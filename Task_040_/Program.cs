// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ChekTriangle(int sideA, int sideB, int sideC)
{
    if (sideA < (sideA + sideC) && sideB < (sideA + sideC) && sideC < (sideA + sideB))
        return true;
    return false;
}


int a = UserInputInt("Введите длину стороны а: ");
int b = UserInputInt("Введите длину стороны b: ");
int c = UserInputInt("Введите длину стороны c: ");
if (ChekTriangle(a, b, c) == true)
    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует.");
else
    Console.WriteLine("Такой треугольник не существует.");