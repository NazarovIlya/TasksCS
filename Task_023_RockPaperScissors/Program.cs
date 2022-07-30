
Console.Clear();
Console.WriteLine("До скольки очков Вы хотели бы играть: ");
int maxScore = Convert.ToInt32(Console.ReadLine());
int score = 0;

void OutputNobody()
{
    score += 1;
    Console.WriteLine($"Ответ совпал с ответом компьютера. Ваш счет: {score} Продолжаем:");
}
void OutputUserWin()
{
    score += 2;
    Console.WriteLine($"Поздравляю, Вы выиграли! Ваш счет: {score} Продолжаем:");
}
void OutputUserLose()
{
    Console.WriteLine($"К сожалению выиграл компьютер! Ваш счет: {score} Продолжаем:");
}

void RockPaperScissors(int maxScore)
{
    for (int i = 0; score < maxScore; i++)
    {
        Console.WriteLine("Камень, ножницы, бумага?");
        string userAnswer = Console.ReadLine();
        int ans = 0;
        int compAnswer = new Random().Next(1, 3);
        if (userAnswer.ToLower() == "камень") ans = 1;
        else if (userAnswer.ToLower() == "ножницы") ans = 2;
        else if (userAnswer.ToLower() == "бумага") ans = 3;
        if (ans == compAnswer) OutputNobody();
        else if (ans == 1 && compAnswer == 2) OutputUserWin();
        else if (ans == 2 && compAnswer == 3) OutputUserWin();
        else if (ans == 3 && compAnswer == 1) OutputUserWin();
        else if (ans == 2 && compAnswer == 1) OutputUserLose();
        else if (ans == 3 && compAnswer == 2) OutputUserLose();
        else if (ans == 1 && compAnswer == 3) OutputUserLose();
    }
    Console.WriteLine($"Игра окончена. Ваш счет: {score}");
}
RockPaperScissors(maxScore);