using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace CSharpFeatures
{
  //Refleksja pozwala nam na wgląd do metadanych i skompilowanego kodu w assembly
  //assembly - exe lub dll
  //metadane - informacje o metodach polach zmiennych
  //dostep do niepublicznych własciwości, metod, wartości - modyfikacja prywatnych pół może spowodować błąd systemu
  //Można dynamicznie podłączać również publiczne rzeczy 
  public static class SomeReflection
  {
    public static Type TypeOfMethod()
    {
      Type listType = typeof(List<int>);
      return listType;
    }

    public static Type[] TypeOfMethodArray()
    {
      List<int> myList = new List<int>
    {
      1,2,4,5,6,43,3,143
    };

      Type[] parametersType = { typeof(int) };
      return parametersType;
    }


    public static void CreateListReflection()
    {
      Type listType = typeof(List<int>);
      Stopwatch watch = Stopwatch.StartNew();
      for (int i = 0; i < 1000000; i++)
      {
        var testList = Activator.CreateInstance(listType);
      }
      Console.WriteLine(watch.ElapsedMilliseconds + " ms");
    }

    public static void CreateList()
    {
      Stopwatch watch = Stopwatch.StartNew();
      for (int i = 0; i < 1000000; i++)
      {
        var testList = new List<int>();
      }
      Console.WriteLine(watch.ElapsedMilliseconds + " ms");
    }


    public static void AddListElements()
    {
      var list = new List<int>();
      Stopwatch watch = Stopwatch.StartNew();
      for (int i = 0; i < 1000000; i++)
      {
        list.Add(i);
      }
      Console.WriteLine(watch.ElapsedMilliseconds + " ms");
    }


    public static void AddListElementsReflection()
    {
      var list = new List<int>();

      var a = list.GetType();
      Type listType = typeof(List<int>);
      Type[] parametersType = { typeof(int) };
      MethodInfo methodInfo = listType.GetMethod("Add", parametersType);

      Stopwatch watch = Stopwatch.StartNew();
      for (int i = 0; i < 1000000; i++)
      {
        methodInfo.Invoke(list, new object[] { i });
      }
      Console.WriteLine(watch.ElapsedMilliseconds + " ms");
    }

  }
}
