using System;

namespace Behavioral_05_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.ConcreteMediator mediator = new Default.ConcreteMediator();
            //
            // Default.ConcreteColleague1 colleague1 = new Default.ConcreteColleague1(mediator);
            // Default.ConcreteColleague2 colleague2 = new Default.ConcreteColleague2(mediator);
            //
            // mediator.Colleague1 = colleague1;
            // mediator.Colleague2 = colleague2;
            //
            // colleague1.Send("How are you?");
            // colleague2.Send("Fine, thanks.");

            #endregion


            #region Situation

            Situation.Mediator mediator = new Situation.Mediator();

            Situation.StoreDaan storeDaan = new Situation.StoreDaan(mediator);
            Situation.StoreXinyi storeXinyi = new Situation.StoreXinyi(mediator);

            mediator.StoreDaan = storeDaan;
            mediator.StoreXinyi = storeXinyi;

            storeDaan.GetInStore();
            storeDaan.GetOtherStoreInStore();

            #endregion

            Console.ReadLine();
        }
    }
}
