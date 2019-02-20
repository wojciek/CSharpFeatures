using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializationXML
{
  class Program
  {

    static void Main(string[] args)
    {
      Person person = new Person();
      person.Name = "Wojciek";
      person.Surname = "Nazwiskowski";

      Console.WriteLine("Hello World!");

      XmlSerializer xs = new XmlSerializer(typeof(Person));
      using (Stream s = File.Create(@"C:\Users\w.gluch\Desktop\osoba.xml"))
        xs.Serialize(s, person);

      // Deserialize 

      Person personDeserialized;

      XmlSerializer xmlDeserialized = new XmlSerializer(typeof(Person));
      using (Stream fileStream = File.OpenRead(@"C:\Users\w.gluch\Desktop\osoba.xml"))
      {
        personDeserialized = (Person)xmlDeserialized.Deserialize(fileStream);
      }

      Console.WriteLine(personDeserialized.Name);
      Console.ReadKey();
    }
  }
}
