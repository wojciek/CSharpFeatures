using System;
using System.Linq;

namespace SmallestHigher
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      while (true)
      {
        var value = Convert.ToInt32(Console.ReadLine());
        GetSmallestHigherValue(ref value);

        Console.WriteLine(value);

        var exit = Console.ReadKey();
        if (exit.Key == ConsoleKey.Escape)
        {
          break;
        }
      }

      Console.ReadKey();
    }

    public static int GetSmallestHigherValue(ref int value)
    {
      value++;

      while (true)
      {
        if ((value % 2 != 0 && (value % 3) == 0))
        {
          var number = value.ToString();

          if (number.Distinct().Count() > 1)
          {
            return value;
          }
        }
        value++;
      }
    }
  }
}
