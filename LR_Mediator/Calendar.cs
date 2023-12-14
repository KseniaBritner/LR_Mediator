using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Mediator
{
    public class Calendar
    {
        protected CalendarMediator _mediator;
        public Calendar(CalendarMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        public void OnEvent()
        {
            _mediator.Execute(new NewDayRequest());
        }
    }
}
