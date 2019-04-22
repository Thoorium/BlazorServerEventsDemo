using System;

namespace BlazorServerEventsDemo.Services
{
    public class DummyNumberService
    {
        private int number = 0;
        public int Number
        {
            get { return number;}
            set 
            { 
                number = value;
                NewNumberEvent?.Invoke(this, new NumberEventArgs(number));
            }
        }
        
        public event NumberEventHandler NewNumberEvent;
        public delegate void NumberEventHandler(object sender, NumberEventArgs e); 
    }
}