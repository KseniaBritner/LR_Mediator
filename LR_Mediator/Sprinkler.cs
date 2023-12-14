using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Mediator
{
    public class Sprinkler
    {
        public void Check(CalendarEventRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            Console.WriteLine($"Разбрызгиватель будет включен {request.Date}");
        }
        public void Check(AlarmRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            Console.WriteLine($"Разбрызгиватель будет включен в {request.Time}");
        }
    }
}
