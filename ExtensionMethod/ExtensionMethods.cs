using System;

namespace ExtensionMethod
{
  public static class ExtensionMethods
  {
    public static int WordCounter(this string str)
    {
      string[] userText = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
      int counter = userText.Length;
      return counter;
    }
    public static int TotalCharactersWithoutSpace(this string str)
    {
      int counter = 0;
      string[] userText = str.Split(' ');
      foreach (var item in userText)
      {
        counter += item.Length;
      }



      return counter;
    }
  }
}
