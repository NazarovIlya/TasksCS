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
    if (number / 100 == 0)
        return 0;
    else
    {
        while (number > 1000)
        {
            number = number / 10;
        }
        res = number % 10;
        return res;
    }
}
int result = ThirdDigital(num);
if (result == 0)
    Console.WriteLine("Третьей цифры нет.");
else
    Console.WriteLine($"{num} --> {result}");