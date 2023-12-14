using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static LR_Mediator.CalendarRequest;

namespace LR_Mediator
{
    public class CoffeePot
    {
        public void Check(NewDayRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            var day = new DateTime(request.Date.Year, request.Date.Month, request.Date.Day).DayOfWeek;
            if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                Console.WriteLine("Сегодня выходной");
            }
            else
            {
                Console.WriteLine("Сегодня будний день");
                if (DateTime.Now.Hour < 12)
                {
                    Console.WriteLine("Кофе готовится");
                }
            }
        }
        public void Check(AlarmRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            Console.WriteLine($"Кофе будет готов в {request.Time}");
        }
        public void Check(DateTime date)
        {
            if (date == null)
            {
                throw new ArgumentNullException(nameof(date));
            }
            Console.WriteLine($"Кофе будет готов {date.Year}/{date.Month}/{date.Day} в {date.Hour}:{date.Minute}");
        }
    }
}
