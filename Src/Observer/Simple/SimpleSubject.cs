using System.Collections.Generic;

namespace Observer.Simple
{
    public class SimpleSubject : ISubject {
        private IList<IObserver> observers;
        private int value = 0;
        
        public SimpleSubject() 
        {
            observers = new List<IObserver>();
        }
        
        public void registerObserver(IObserver o) 
        {
            observers.Add(o);
        }
        
        public void removeObserver(IObserver o) 
        {
            observers.Remove(o);
        }
        
        public void notifyObservers() 
        {
            foreach (IObserver observer in observers) 
            {
                observer.update(value);
            }
        }
        
        public void setValue(int value) 
        {
            this.value = value;
            notifyObservers();
        }
    }
}