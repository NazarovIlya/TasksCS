
Console.WriteLine("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 / num2;
if(result == num2)
Console.WriteLine("Yes");
else Console.WriteLine("No");
