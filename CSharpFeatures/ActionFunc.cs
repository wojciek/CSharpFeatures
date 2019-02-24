using System;

namespace CSharpFeatures
{
  public class ActionFunc
  {
    delegate double CalculateSomething(double x);

    public void Calc()
    {
      CalculateSomething someCircle = x => Math.PI * x * x;

      double circle = someCircle(15);

      Console.WriteLine(circle);
    }

    public void SomeFunc()
    {
      //Func--------------------------------------------------------------------Func<TParameter, TOutput>
      //skrocony sposob tworzenia delegata do jednej linijki z Func - czyli delegata zwracająca
      Func<Double, Double> someFunc = y => { return y * y; };//działąnie i zwrot danych
      double some = someFunc(15);
      Console.WriteLine(some);

      //Action--------------------------------------------------------------------Action<T> a'la void
      //Action delegata nic nie zwracająca 
      Action<string, string, int> SomeAction = (z, i, a) => Console.WriteLine("Wynik z delegata z zmienną : " + z + i + 500 * a);//tutaj po prostu jakieś działanie

      SomeAction("pierwszy wjesciowy", "drugi wejsciowy", 44);
    }

    //Przykład uzycia Func
    public double ReturnValue(string firstCriteria, string secondCriteria)
    {
      if (firstCriteria.Equals("BMW") && secondCriteria.Equals("M6"))
        return 560000;
      if (firstCriteria.Equals("Audi") && secondCriteria.Equals("R8"))
        return 860000;
      else
        return -1;
    }

    //Przykład uzycia Action
    public void DoSomething(string firstCriteria, string secondCriteria)
    {
      if (firstCriteria.Equals("Audi") && secondCriteria.Equals("RS6"))
        Console.WriteLine("Wybrałeś auto 'rodzinne': {0} {1}", firstCriteria, secondCriteria);
      if (firstCriteria.Equals("Audi") && secondCriteria.Equals("R8"))
        Console.WriteLine("Wybrałeś auto sportowe: {0} {1}", firstCriteria, secondCriteria);
      else
        Console.WriteLine("Nieznany rodzaj samochodu");
    }
  }
}
