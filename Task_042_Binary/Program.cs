// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Binary(int number)
{
    //int count = 0;
    if (number == 0) return;
    Binary(number / 2);
    Console.Write(number % 2);
}

Console.Clear();
int num = UserInputInt("Enter");
Binary(num);
