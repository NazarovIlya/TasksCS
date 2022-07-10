/*Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.*/
Console.Clear();
Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine($"Введеные числа равны {num1} = {num2}");
}
else
if (num1 > num2)         // использован оператор if, так как на вход поступает только два числа
{
    Console.WriteLine($"Максимальное число = {num1}");  // в случае с большим количеством чисел
    Console.WriteLine($"Минимальное число = {num2}");   // были бы использованы доп. переменые min и max
}
else
{
    Console.WriteLine($"Максимальное число = {num2}");
    Console.WriteLine($"Минимальное число = {num1}");
}