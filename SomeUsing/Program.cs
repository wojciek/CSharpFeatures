using System;
using System.IO;

namespace SomeUsing
{
  class Program
  {
    static void Main(string[] args)
    {
      //using - ograniczenie czasu życia obiektu do minimum - podajemy obiekt którego chcemy użyć wewnątrz bloku. Po wyjściu z bloku zasoby zostaną zwolnione

      string filePath = "C:\\TestTextFiles";
      Console.WriteLine("Wpisz tekst który ma zostać wpisany do pliku tekstowego w ścieżce: " + filePath);
      string text = Console.ReadLine();

      WriteSomethingToFile(text, filePath);

      Console.ReadKey();
    }


    public static void WriteSomethingToFile(string text, string filePath)
    {
      if (!Directory.Exists(filePath))
      {
        Directory.CreateDirectory(filePath);
      }

      if (!File.Exists(filePath + "\\TestText.txt"))
      {
        using (StreamWriter streamWriter = new StreamWriter(filePath + "\\TestText.txt")) // Auto file close doed by using
        {
          streamWriter.WriteLine(text);
        }
      }



    }
  }
}
