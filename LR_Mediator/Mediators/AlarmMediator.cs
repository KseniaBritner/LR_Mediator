﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Mediator
{
    public class AlarmMediator : IMediator
    {
        protected CoffeePot _coffeePot;
        protected Sprinkler _sprinkler;
        public AlarmMediator(CoffeePot coffeePot, Sprinkler sprinkler)
        {
            _coffeePot = coffeePot ?? throw new ArgumentNullException(nameof(coffeePot));
            _sprinkler = sprinkler ?? throw new ArgumentNullException(nameof(sprinkler));
        }
        public void Execute(IRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (request is AlarmRequest alarmRequest)
            {
                _coffeePot.Check(alarmRequest);
                _sprinkler.Check(alarmRequest);
            }
        }
    }
}
    
