using System;

namespace BlazorServerEventsDemo.Services
{
    public class DummyCounterService
    {
        private int number;
        public int Number
        {
            get { return number;}
        }
        
        public void Increment()
        {
            number += 1;
            NumberUpdatedEvent?.Invoke(this, new NumberEventArgs(number));
        }

        public void Reset()
        {
            number = 0;
            NumberUpdatedEvent?.Invoke(this, new NumberEventArgs(number));
        }
        public event NumberEventHandler NumberUpdatedEvent;
        public delegate void NumberEventHandler(object sender, NumberEventArgs e); 
    }
}