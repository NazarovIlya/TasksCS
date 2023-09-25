using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PearsonCorrelation
{
  internal class PearsonCalc
  {
    public PearsonCalc() { }

    public double Calculate(Item[] itemsArray)
    {
      int length = itemsArray.Length;
      int sumX = 0, sumY = 0;
      double numerator = 0, denominator = 0;

      foreach (var item in itemsArray)
      {
        sumX += item.first;
        sumY += item.second;
      }
      int averageX = sumX / length;
      int averageY = sumY / length;

      foreach (var item in itemsArray)
      {
        numerator += ((item.first - averageX) * (item.second - averageY));
        denominator += (double)(BigInteger.Pow(item.first - averageX, 2) * BigInteger.Pow(item.second - averageY, 2));
      }
      double result = numerator / (int)Math.Sqrt(denominator);
      return result;
    }
  }
}
