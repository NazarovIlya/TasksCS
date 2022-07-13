// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int dayInput = Convert.ToInt32(Console.ReadLine());

int DayOfWeek(int day)
{
    int dayNumber = 0;                  // 0 = день не является выходным, задаем изначально
    if ((day > 0) && (day < 8))
    {
        if ((day == 6) || (day == 7))
            return dayNumber = 1;       // 1 = день является выходным
        else return dayNumber;          // dayNumber == 0;
    }
    else return dayNumber = -1;         // -1 = введеное число не соответствует ни одному из дней недели
}

int weekDay = DayOfWeek(dayInput);
if (weekDay == 1)
    Console.WriteLine("Поздравляю Вас с выходным днем!");
else if (weekDay == 0)
    Console.WriteLine("К сожалению, еще идет рабочая неделя, будний день.");
else if (weekDay == -1)
    Console.WriteLine("Введеное Вами число не соответствует ни одному из дней недели");