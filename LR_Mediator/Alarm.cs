using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Mediator
{
    public class Alarm
    {
        protected AlarmMediator _mediator;
        public Alarm(AlarmMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        public void OnEvent()
        {
            _mediator.Execute(new AlarmRequest(DateTime.UtcNow));
        }
    }
}
