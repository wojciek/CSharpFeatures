using System;

namespace Attributes
{
  public class HelpAttribute : Attribute
  {
    protected readonly string _description;

    public HelpAttribute(string description)
    {
      _description = description;
    }
  }

  public class MarkingAttribute : Attribute
  {
  }
}
