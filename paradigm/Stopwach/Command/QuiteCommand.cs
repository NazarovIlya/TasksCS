using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwach.Command
{
  internal class QuiteCommand : ICommand
  {
    public string Description() => "Press to  QUITE stopwatch";

    public void Execute()
    {
      throw new NotImplementedException();
    }
  }
}
