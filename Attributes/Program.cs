using System;

namespace Attributes
{
  class Program
  {
    static void Main(string[] args)
    {
      TestOne();
      TestTwo();
      Console.WriteLine("Hello World!");


      OldMethod();


      Console.ReadKey();
    }
    [Help("Opis metody TestOne")]
    public static void TestOne()
    {
      Console.WriteLine("Some Attribute inside method");
    }

    [Marking]
    public static void TestTwo()
    {
      Console.WriteLine("Inside Testing attribute method");
    }

    [Obsolete("Olddated Method Use NewMehod")]
    public static void OldMethod()
    {
      Console.WriteLine("Stara metoda");
    }

    public static void NewMethod()
    {
      Console.WriteLine("Nowa metoda");
    }
  }


  [Help("Opis klasy Something")]
  public class Something
  {
    public string Name { get; set; }
    public string City { get; set; }
  }
}
