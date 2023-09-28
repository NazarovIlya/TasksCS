using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwach.Command
{
  internal class QuiteCommand : ICommand
  {
    Model model;
    View view;

    public QuiteCommand(Model model, View view)
    {
      this.model = model;
      this.view = view;
    }

    public string Description() => "Press to  QUITE stopwatch";

    public void Execute()
    {
      model.State = false;
      view.PrintCount(model);
    }
  }
}
