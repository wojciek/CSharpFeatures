using System;

namespace ExtensionMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      string text = string.Empty;
      text = "Testowe zdanie do sprawdzenia!. Policzymy różne rzeczy w stringu, które mogą okazać się ciekawe.";

      Console.WriteLine(text.WordCounter());
      Console.WriteLine(text.TotalCharactersWithoutSpace());
      Console.ReadKey();
    }
  }
}
