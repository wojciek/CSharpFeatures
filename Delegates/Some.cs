using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Delegates
{
  public class Some
  {
    public delegate void SomeMethodDelegate(int i);

    public void SomeMethod(SomeMethodDelegate someMethodDelegate)
    {
      int a = 0;
      for (int i = 0; i < 10; i++)
      {
        someMethodDelegate(i);
        a = a + i;
        Thread.Sleep(1000);
      }
    }

    public delegate double CalculateDel(double x);

    public static CalculateDel calculateSome = Calculate;

    //wywołanie delegata
    public static void Wow()
    {
      double someSpace = calculateSome.Invoke(50);
      Console.WriteLine(someSpace);
    }

    public static double Calculate(double x)
    {
      return x * x * x;
    }
  }
}
