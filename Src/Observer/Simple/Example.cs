using System;

namespace Observer.Simple
{
    public class Example
    {
        static void  Main(string[] args)
        {
            SimpleSubject simpleSubject = new SimpleSubject();
            SimpleObserver simpleObserver = new SimpleObserver(simpleSubject);
            simpleSubject.setValue(80);
            simpleSubject.removeObserver(simpleObserver);
        }
    }
}