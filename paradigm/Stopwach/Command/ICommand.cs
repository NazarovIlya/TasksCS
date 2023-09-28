using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwach.Command
{
    internal interface ICommand
    {
      public string Description();
      public void Execute();
    }
}
