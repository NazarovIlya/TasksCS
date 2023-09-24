using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearsonCorrelation
{
  public record Item
  {
    public Item(int first, int second)
    {
      this.first = first;
      this.second = second;
    }

    public int first { get; set; }
    public int second { get; set; }
  }
}
