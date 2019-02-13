using System;
using EventDomain;

namespace EventReceiver
{
  class Program
  {

    static void Main(string[] args)
    {

      ScheduleManager scheduleManager = new ScheduleManager();
      NotificationSender notificationSender = new NotificationSender();

      ShowNotification eventReceiver = new ShowNotification();
      ShowNotificationShort showNotificationShort = new ShowNotificationShort();

      scheduleManager.AddedSchedule += eventReceiver.OnAddedSchedule; // EventReceiver nasłuchuje na event
      scheduleManager.AddedSchedule += notificationSender.OnAddedSchedule; // NotificationSender nasłuchuje na event
      scheduleManager.AddedScheduleShort += showNotificationShort.OnAddedScheduleShort; // Nasłuchiwanie na drugi event


      scheduleManager.AddSchedule(new Schedule()
      {
        ScheduleDate = DateTime.Now,
        ScheduleName = "Kupić masło"
      });


      Console.WriteLine("Zakończono działanie programu.....");
      Console.ReadKey();
    }


  }
}
