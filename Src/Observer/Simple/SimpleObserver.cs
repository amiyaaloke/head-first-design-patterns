using System;

namespace Observer.Simple
{
    public class SimpleObserver : IObserver 
    {
        private int value;
        private ISubject simpleSubject;
        
        public SimpleObserver(ISubject simpleSubject) 
        {
            this.simpleSubject = simpleSubject;
            simpleSubject.registerObserver(this);
        }
        
        public void update(int value) 
        {
            this.value = value;
            display();
        }
        
        public void display() 
        {
            Console.WriteLine("Value: " + value);
        }
    }
}