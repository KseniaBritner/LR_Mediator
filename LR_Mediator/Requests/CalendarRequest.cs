using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Mediator
{
    public class CalendarRequest : IRequest
    {
        public DateTime Date { get; private set; }
        public CalendarRequest(DateTime date)
        {
            Date = date;
        }
    }
}
