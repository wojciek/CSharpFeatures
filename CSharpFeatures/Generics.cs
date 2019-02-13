using System;

namespace CSharpFeatures
{
  //opóźnienie dostarczania typu - logika oddzielona od typu
  public class Generics
  {
    static void GenericsMethod()
    {
      Compare<string> compareString = new Compare<string>();

      Console.WriteLine(compareString.CompareAny("ale", "ale"));
    }
  }


  public class Compare<T>
  {
    public bool CompareAny(T a, T b)
    {
      if (a.Equals(b))
      {
        return true;
      }
      else
      {
        return false;
      }
    }


  }

}
