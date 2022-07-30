
Console.Clear();
Console.WriteLine("До скольки очков Вы хотели бы играть: ");
int maxScore = Convert.ToInt32(Console.ReadLine());

void RockPaperScissors(int maxScore)
{
    int score = 0;
    for (int i = 0; score < maxScore; i++)
    {
        Console.WriteLine("Камень, ножницы, бумага?");
        string userAnswer = Console.ReadLine();
        int ans = 0;
        int compAnswer = new Random().Next(1, 3);
        if (userAnswer.ToLower() == "камень") ans = 1;
        else if (userAnswer.ToLower() == "ножницы") ans = 2;
        else if (userAnswer.ToLower() == "бумага") ans = 3;
        if (ans == compAnswer)
        {
            score += 1;
            Console.WriteLine($"Поздравляю, Ваш ответ совпал с ответом комьютера! Ваш счет: {score}");
        }
        else if (ans == 1 && compAnswer == 2)
        {
            score += 2;
            Console.WriteLine($"Поздравляю, Вы выиграли! Ваш счет: {score} Продолжаем:");
        }
        else if (ans == 2 && compAnswer == 3)
        {
            score += 2;
            Console.WriteLine($"Поздравляю, Вы выиграли! Ваш счет: {score} Продолжаем:");
        }
        else if (ans == 3 && compAnswer == 1)
        {
            score += 2;
            Console.WriteLine($"Поздравляю, Вы выиграли! Ваш счет: {score}. Продолжаем:");
        }
        else if (ans == 2 && compAnswer == 1)
        {
            score += 2;
            Console.WriteLine($"К сожалению выиграл компьютер! Ваш счет: {score} Продолжаем:");
        }
        else if (ans == 3 && compAnswer == 2)
        {
            score += 2;
            Console.WriteLine($"К сожалению выиграл компьютер! Ваш счет: {score} Продолжаем:");
        }
        else if (ans == 1 && compAnswer == 3)
        {
            score += 2;
            Console.WriteLine($"К сожалению выиграл компьютер! Ваш счет: {score} Продолжаем:");
        }
        else score += 0;
    }
    Console.WriteLine($"Игра окончена. Ваш счет: {score}");
}

RockPaperScissors(maxScore);