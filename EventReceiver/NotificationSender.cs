using System;
using EventDomain;

namespace EventReceiver
{
  public class NotificationSender

  {
    public void OnAddedSchedule(object o, ScheduleEventArgs e)
    {
      Console.WriteLine("Notification was send ! Nazwa: " + e.Schedule.ScheduleName);
    }
  }
}
