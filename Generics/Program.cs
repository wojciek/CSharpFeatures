using System;

namespace Generics
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var wartoscPierwsza = "wartosc pierwsza";
      var wartoscDruga = "wartosc druga";

      Replace(ref wartoscPierwsza, ref wartoscDruga); // przez ref zmieniamy wartość referenzyjnie dla pozostałej części kodu
      Console.WriteLine("Wartość pierwsza po zamiance: " + wartoscPierwsza);
      Console.WriteLine("Wartość druga po zamiance: " + wartoscDruga);

      Console.WriteLine("-------------------------------------------------------------");
      MergeAndShow(ref wartoscPierwsza, ref wartoscDruga);

      string a;
      int b;
      SetValue(out a, out b);
      MergeAndShow(ref a, ref b);

      Console.ReadKey();
    }

    public static void Replace<T>(ref T var1, ref T var2)
    {
      T helper = var1;
      var1 = var2;
      var2 = helper;
    }

    public static void MergeAndShow<T1, T2>(ref T1 var1, ref T2 var2)
    {
      Console.WriteLine("Połączone wartości po zamianie: {0} {1}", var1, var2);
    }

    public static void SetValue(out string var1, out int var2)
    {
      var1 = "nadana wartość referencyjna pierwsza";
      var2 = 2;
    }
  }
}
