using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFeatures
{
  class Program
  {
    static List<int> myList = new List<int>();

    static List<string> stringList = new List<string>();
    static void Main(string[] args)
    {
      FillList();
      //cała lista
      ShowListElements(myList);
      DivLine();
      //wyfiltrowana lista jednak tworzymy nową liste która zawiera wyfiltrowane dane
      ShowListElements(Filter());
      DivLine();
      //zwraca oryginalne dane bez tworzenia temp listy która zawiera wynikowe wyfiltrowane dane
      ShowListElements(YieldFilter(myList));
      DivLine();
      //filtrowanie za pomocą wbudowanej metody Linq
      ShowListElements(myList.Where(x => x > 3));// tutaj prawdopodobnie również pod spodem działa yield
      DivLine();
      ShowListElements(Calculate(myList));


      Console.WriteLine("The end of application!");
      Console.ReadKey();
    }

    static void FillList()
    {
      myList.Add(1);//false
      myList.Add(2);//false
      myList.Add(3);//false
      myList.Add(4);//true
      myList.Add(5);//true
      myList.Add(6);//true
      myList.Add(7);//true
      myList.Add(8);//true
      myList.Add(9);//true
      myList.Add(10);//true
    }

    static void FillStringList()
    {
      stringList.Add("jeden");
      stringList.Add("jeden");
      stringList.Add("dwa");
      stringList.Add("dwa");
      stringList.Add("dwa");
      stringList.Add("jeden");
      stringList.Add("trzy");
      stringList.Add("trzy");
      stringList.Add("cztery");
    }


    //zwykła metoda filtrująca
    static IEnumerable<int> Filter()
    {
      List<int> temporaryList = new List<int>();//zaśmiecamy pamięć kolejną listą tymczasową
      foreach (var listItem in myList)
      {
        if (listItem > 3)
        {
          temporaryList.Add(listItem);
        }
      }
      return temporaryList;
    }

    // Custom iteration yield zachowuje stan poprzedniej pętli
    static IEnumerable<int> YieldFilter(IEnumerable<int> list)
    {

      foreach (var listItem in list)
      {
        if (listItem > 3)
        {
          yield return listItem;
        }
      }
    }

    static IEnumerable<int> Calculate(IEnumerable<int> list)
    {
      int total = 0;
      foreach (var listItem in list)
      {
        total = total + listItem;
        yield return total;
      }
    }

    static void Show(object data)
    {
      Console.WriteLine(data);
    }

    static void DivLine()
    {
      Console.WriteLine("-------------------------------");
    }

    static void ShowListElements(IEnumerable<int> list)
    {
      foreach (var listItem in list)
      {
        Show(listItem);
      }
    }
  }
}
