using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Collections
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> dictionary = new Dictionary<string, string>();

      dictionary.Add("imie", "wojciek");
      dictionary.Add("miasto", "warszawa");
      dictionary.Add("numer", "jan");
      dictionary.Add("kod", "krzysztof");
      foreach (var item in dictionary.Where(x => x.Key == "imie"))
      {
        Console.WriteLine(item);
        Console.WriteLine(item.GetType());
      }
      ;

      Collection<string> ienumerable = new Collection<string>();
      ienumerable.Add("jeden");
      ienumerable.Add("jeden");
      ienumerable.Add("dwa");
      ienumerable.Add("trzy");

      foreach (var item in ienumerable.Where(x => x == "jeden"))
      {
        Console.WriteLine(item);
      }

      List<string> list = new List<string>();

      list.Add("pierwszy");
      list.Add("drugi");
      list.Add("pierwszy");
      list.Add("jeden;kd;aldxad");
      list.Add("bjdksandjedenlasjdkas");
      list.Add("dadjeden");
      list.Add("trzeci");

      Console.WriteLine(list.Where(x => x == "pierwszy").Count());
      foreach (var item in list.Where(x => x.Contains("jeden")))
      {
        Console.WriteLine(item);
      }
      Console.WriteLine(list.IndexOf(list.Where(x => x.Contains("drug")).FirstOrDefault()) + 1);


      Console.ReadKey();
    }
  }
}
