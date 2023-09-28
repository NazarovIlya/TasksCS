using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwach
{
  internal class Model
  {
    public int Counter { get; set; }
    public bool State { get; set; }

    public Model()
    {
      Counter = 0;
      State = false;
    }

    public void Count()
    {
      Thread.Sleep(1000);
      this.Counter++;
    }
  }
}
