// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.WriteLine("Введите номер четверти: ");
string num = Console.ReadLine();

string FindCoordinateInterval(string q)
{
    if (q == "1") return ("x > 0 ; y > 0");
    if (q == "2") return ("x < 0 ; y > 0");
    if (q == "3") return ("x < 0 ; y < 0");
    if (q == "4") return ("x > 0 ; y < 0");
    return ("Введена несуществующая четверть");
}

string result = FindCoordinateInterval(num);
Console.WriteLine(result);
