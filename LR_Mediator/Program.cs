using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmMediator alarmMediator = new AlarmMediator(new CoffeePot(), new Sprinkler());
            CalendarMediator calendarMediator = new CalendarMediator(new CoffeePot(), new Sprinkler());
            Alarm alarm = new Alarm(alarmMediator);
            Calendar calendar = new Calendar(calendarMediator);
            calendar.OnEvent();
            alarm.OnEvent();
        }
    }
}
