using System;

namespace BlazorServerEventsDemo.Services
{
    public class NumberEventArgs : EventArgs  
    {  
        public NumberEventArgs(int i)  
        {  
            number = i;  
        }  
        private int number;  
        public int Number  
        {  
            get { return number; }  
        }   
    } 
}