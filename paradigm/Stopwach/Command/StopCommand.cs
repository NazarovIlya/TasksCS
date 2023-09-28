using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwach.Command
{
  internal class StopCommand : ICommand
  {
    Model model;
    View view;

    public StopCommand(Model model, View view)
    {
      this.model = model;
      this.view = view;
    }
    public string Description() => "Press to STOP stopwatch";

    public void Execute()
    {
      model.Counter = 0;
      view.PrintCount(model);
    }
  }
}
