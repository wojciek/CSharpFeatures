using System;
using EventDomain;

namespace EventReceiver
{
  public class ShowNotificationShort
  {
    public void OnAddedScheduleShort(object o, ScheduleEventArgs e)
    {
      Console.WriteLine("EVENT RECEIVER: Reakcja Show notification SHORT na podniesienie eventu w EventService !" + e.Schedule.ScheduleDate + "  :  " + e.Schedule.ScheduleName);

      e.Schedule.ScheduleName = e.Schedule.ScheduleName + "DODANE INFO Z ShowNotification SHORT";
    }
  }
}
