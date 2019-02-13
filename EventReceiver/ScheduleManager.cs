using System;
using System.Threading;
using EventDomain;

namespace EventReceiver
{
  public class ScheduleManager
  {
    public delegate void AddedScheduleEventHandler(object o, ScheduleEventArgs e);//forma standardowa
    public event AddedScheduleEventHandler AddedSchedule;//forma standardowa

    public event EventHandler<ScheduleEventArgs> AddedScheduleShort;//skrócona forma

    //Event publisher powinien być protected virtual void nazwa zaczyna się od "On" 


    // Event Publisher
    protected virtual void OnAddedSchedule(Schedule schedule) //odbieramy
    {
      if (AddedSchedule != null)
      {
        AddedSchedule(this, new ScheduleEventArgs() { Schedule = schedule }); // przesyłamy obiekt dalej
      }
    }

    protected virtual void OnAddedScheduleShort(Schedule schedule)
    {
      if (AddedScheduleShort != null)
      {
        AddedScheduleShort(this, new ScheduleEventArgs() { Schedule = schedule });
      }
    }

    public void AddSchedule(Schedule schedule) // przekazujemy
    {
      Console.WriteLine("SCHEDULE MANAGER: Add Schedule: Zaczynam dodawać wydarzenie ... ");

      OnAddedSchedule(schedule); //odpalenie pierwszego eventu
      Thread.Sleep(3000);

      OnAddedScheduleShort(schedule);// odpalenie drugiego eventu
      Console.WriteLine("SCHEDULE MANAGER: Add Schedule: Skończyłem dodawać wydarzenie ... ");
    }
  }
}
