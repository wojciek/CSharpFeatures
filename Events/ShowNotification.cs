using System;
using EventDomain;

namespace EventReceiver
{
  public class ShowNotification
  {
    public void OnAddedSchedule(object o, ScheduleEventArgs e)
    {
      Console.WriteLine("EVENT RECEIVER: Reakcja Show notification na podniesienie eventu w EventService !" + e.Schedule.ScheduleDate + "  :  " + e.Schedule.ScheduleName);

      e.Schedule.ScheduleName = e.Schedule.ScheduleName + "DODANE INFO Z ShowNotification";
    }
  }
}
