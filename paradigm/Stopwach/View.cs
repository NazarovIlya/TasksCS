using Stopwach.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stopwach
{
  internal class View
  {
    private int startIndex = 1;
    public int Menu(List<ICommand> commands)
    {
      for (int i = 0; i < commands.Count; i++)
      {
        Console.WriteLine($"{i + startIndex} --> {commands[i].Description()}");
      }
      return MenuIndex(commands);
    }

    public void PrintCount(Model model) => Console.Write($"\r{model.Counter}");

    private int MenuIndex(List<ICommand> commands)
    {
      bool flag = true;
      int index = 0;
      string? input = string.Empty;
      Regex regex = new Regex($"^[{startIndex}-{commands.Count}]+$", RegexOptions.Compiled);
      while (flag)
      {
        Console.Write("Press the key to choose stopwatch command from the list:\t\n");
        Console.WriteLine("To change the state, press ENTER");
        input = Console.ReadLine();
        if (input.All(char.IsDigit) && regex.IsMatch(input))
        {
          index = int.Parse(input);
          flag = false;
        }
      }
      return index - startIndex;
    }
  }
}
