using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Stopwach.Command
{
  internal class PauseCommand : ICommand
  {
    private Model model;
    View view;

    public PauseCommand(Model model, View view)
    {
      this.model = model;
      this.view = view;
    }
    public string Description() => "Press to PAUSE stopwatch";

    public void Execute()
    {
      model.Counter = model.Counter;
      view.PrintCount(model);
      //model.State = false;
    }
  }
}
