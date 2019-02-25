using System;

namespace Delegates
{
  class Program
  {
    static void SomeDelegateMethod(int i)
    {
      Console.WriteLine("Dane z metody innej klasy przez uzycie delegata:" + i);
    }
    static void Main(string[] args)
    {
      Some some = new Some();
      some.SomeMethod(SomeDelegateMethod);

      //wywołanie delegata
      Some.Wow();
      Console.WriteLine("The end of application!");
      Console.ReadKey();

      //Delegaty Action i Func
      ActionFunc actionFunc = new ActionFunc();
      Func<string, string, double> returningFunction = actionFunc.ReturnValue;
      double returnedResult = returningFunction("BMW", "M6");
      Console.WriteLine("Zwrócona wartośc z delegata Func: " + returningFunction("BMW", "M6"));
      Action<string, string> doSomethingVoid = actionFunc.DoSomething;
      doSomethingVoid("Audi", "R8");

      Console.ReadKey();
    }
  }
}
