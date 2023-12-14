using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Mediator
{
    public class AlarmRequest : IRequest
    {
        public DateTime Time { get; private set; }
        public AlarmRequest(DateTime time)
        {
            Time = time;
        }
    }
}
