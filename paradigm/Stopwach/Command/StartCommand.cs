using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwach.Command
{
  internal class StartCommand : ICommand
  {
    private Model model;
    View view;
    public StartCommand(Model model, View view)
    {
      this.model = model;
      this.view = view;
    }
    public string Description() => "Press to START stopwatch";
    public void Execute()
    {
      model.State = true;
      view.PrintCount(model);
      model.Count();
    }
  }
}
