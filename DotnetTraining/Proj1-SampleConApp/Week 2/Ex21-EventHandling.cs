using System;
using System.Threading;

namespace Proj1_SampleConApp.Week_2
{
    //We will use Action Delegate for creating events in our app as an example. 

    class AlarmClock
    {
        private DateTime _alarmTime;
        public event Action<string> RaiseAlarm;
        public AlarmClock(DateTime alarm)
        {
            _alarmTime = alarm;
        }

        public void Display()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                if(DateTime.Now.Minute == _alarmTime.Minute)
                {
                    if (RaiseAlarm != null)
                        RaiseAlarm("Time to go for Tea!!!!");
                }
                Thread.Sleep(1000);
            } while (true);
        }
    }
    class Ex21_EventHandling
    {
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock(DateTime.Now.AddMinutes(1));
            clock.RaiseAlarm += Clock_RaiseAlarm;
            clock.Display();
        }

        private static void Clock_RaiseAlarm(string value)
        {
            Console.WriteLine(value);
        }
    }
}
