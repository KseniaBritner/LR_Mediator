using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Mediator
{
    public class CalendarEventRequest : CalendarRequest
    {
        public CalendarEventRequest(DateTime Date) : base(Date) { }
    }
}
