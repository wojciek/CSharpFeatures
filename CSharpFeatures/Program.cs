using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFeatures
{
  class Program
  {
    static List<int> myList = new List<int>();
    static void Main(string[] args)
    {
      ActionFunc actionFunc = new ActionFunc();

      Func<string, string, double> returningFunction = actionFunc.ReturnValue;

      double returnedResult = returningFunction("BMW", "M6");
      Show("Zwrócona wartośc z delegata Func: " + returningFunction("BMW", "M6"));


      Action<string, string> doSomethingVoid = actionFunc.DoSomething;

      doSomethingVoid("Audi", "R8");


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
      DivLine();


      //wystąpienia tych samych cyfr w kolekcji--------------------------------------------------------------------
      int test = 12697332;
      var testArray = test.ToString().ToCharArray();

      var groups = testArray.GroupBy(v => v);
      foreach (var group in groups)
        Console.WriteLine("Value {0} has {1} items", group.Key, group.Count());
      DivLine();



      //wystąpienia tych samych cyfr w kolekcji inny sposób
      int count = 1;
      for (int i = 0; i < testArray.Length; i++)
      {
        for (int j = i; j < testArray.Length - 1; j++)
        {
          if (testArray[i] == testArray[j + 1])
            Console.WriteLine("Powtarza się liczba" + testArray[i]);
        }
      }


      //--------------------------------------------------------------------
      Console.ReadKey();
      Some some = new Some();
      some.SomeMethod(SomeDelegateMethod);
      DivLine();



      //--------------------------------------------------------------------
      Some.Wow();
      Console.WriteLine("The end of application!");
      Console.ReadKey();
    }

    static void SomeDelegateMethod(int i)
    {
      Show("Dane z metody innej klasy przez uzycie delegata:" + i);
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
