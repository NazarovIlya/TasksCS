namespace PearsonCorrelation;

internal class Program
{
  private static void Main(string[] args)
  {
    Item[] items = {
      new(2, 2), new(5, 7), new(9, 1), new(3, 5),
      new(4, 2), new(-4, 12), new(14, -8), new(4, 4),
      new(6, 2), new(1, 10), new(4, 6), new(5, 14),
      new(1, 8), new(-35, 2), new(14, -80), new(40, 4)
    };

    PearsonCalc calc = new PearsonCalc();

    Console.WriteLine(string.Format("Pearson correlation ratio: {0:N4}", calc.Calculate(items)));
  }
}