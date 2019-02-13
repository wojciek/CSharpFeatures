using System;

namespace EventDomain
{
  public class ScheduleEventArgs : EventArgs
  {
    public Schedule Schedule { get; set; }
  }
}
