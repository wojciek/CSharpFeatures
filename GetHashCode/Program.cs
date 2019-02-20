using System;

namespace GetHashCode
{
  class Program
  {

    static void Main(string[] args)
    {
      SomeObject someObjectOne = new SomeObject()
      {
        Number = 34,
        Name = "Jeden"
      };

      SomeObject someObjectTwo = new SomeObject()
      {
        Number = 12,
        Name = "Dwa"
      };
      SomeObject someObjectThree = new SomeObject()
      {
        Number = 12,
        Name = "Dwa"
      };

      Console.WriteLine(someObjectOne.GetHashCode());
      Console.WriteLine(someObjectTwo.GetHashCode());
      Console.WriteLine(someObjectOne.GetHashCode());
      Console.WriteLine(someObjectTwo.GetHashCode());
      Console.WriteLine(someObjectOne.GetHashCode());
      Console.WriteLine(someObjectTwo.GetHashCode());
      Console.WriteLine(someObjectThree.GetHashCode());

      Console.ReadKey();
    }
  }
}
