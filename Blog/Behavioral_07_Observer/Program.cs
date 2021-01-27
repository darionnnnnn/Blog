using System;

namespace Behavioral_07_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.ConcreteSubject subject = new Default.ConcreteSubject();
            //
            // subject.Attach(new Default.ConcreteObserver(subject, "X"));
            // subject.Attach(new Default.ConcreteObserver(subject, "Y"));
            // subject.Attach(new Default.ConcreteObserver(subject, "Z"));
            //
            // subject.SubjectState = "ABC";
            // subject.Notify();

            #endregion

            #region Situation

            Situation.AppleProduct iPhone = new Situation.AppleProduct("iPhone");
            iPhone.StockType = Situation.StockType.OutOfStock;
            Situation.AppleProduct iPad = new Situation.AppleProduct("iPad");
            iPad.StockType = Situation.StockType.OutOfStock;

            iPhone.Attach(new Situation.ConcreteObserver<Situation.AppleProduct>(iPhone, "John"));
            iPhone.Attach(new Situation.ConcreteObserver<Situation.AppleProduct>(iPhone, "Wayne"));
            iPad.Attach(new Situation.ConcreteObserver<Situation.AppleProduct>(iPad, "Leo"));
            iPad.Attach(new Situation.ConcreteObserver<Situation.AppleProduct>(iPad, "Henry"));

            iPhone.StockType = Situation.StockType.InStock;
            iPad.StockType = Situation.StockType.InStock;

            iPhone.Notify();
            iPad.Notify();

            #endregion

            Console.ReadLine();
        }
    }
}
