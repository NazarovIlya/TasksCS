// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите целое цисло: ");
int num = Convert.ToInt32(Console.ReadLine());

int ThirdDigital(int number)
{
    int res = 0;
    if (num / 100 == 0)
        return 0;
    else
    {
        while (num > 1000)
        {
            num = num / 10;
        }
        res = num % 10;
        return res;
    }

}
int result = ThirdDigital(num);
// if (num >= 1000 || num < -999)
//      Console.WriteLine("Введеное число более трехзначного.");
// else
if (result == 0)
    Console.WriteLine("Третьей цифры нет. Возможно число не является трехзначным и находится в интервале от -99 до 99 или равно 100 / - 100");
else
    Console.WriteLine($"{num} --> {result}");