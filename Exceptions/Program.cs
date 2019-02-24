using System;

namespace Exceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      int w = 1;
      A();
    }
    private static void A()
    {
      int w = 2;
      B();
    }
    private static void B()
    {
      try
      {
        int w = 3;
        C();
      }
      catch (Exception e)
      {
        throw e; // ucina Stacktrace w tym miejscu i nie wiemy skąd pochodzi geneza błędu dlatego tutaj powinno być throw;
      }
    }
    private static void C()
    {
      int w = 4;
      D();
    }
    private static void D()
    {
      int w = 5;
      throw new Exception("The method or operation is not implemented.");
    }
  }
}
