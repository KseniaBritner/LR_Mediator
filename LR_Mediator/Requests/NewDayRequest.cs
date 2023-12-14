using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Mediator
{
    public class NewDayRequest : CalendarRequest
    {
        public NewDayRequest() : base(CurrentDate()) { }
        public static DateTime CurrentDate()
        {
            DateTime dateTime = DateTime.UtcNow;
            return dateTime;
        }
    }
}
