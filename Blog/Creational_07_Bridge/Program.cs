using System;

namespace Creational_07_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default


            Default.IAbstraction abstractionA = new Default.RefinedAbstraction(new Default.ConcreteImplementorA());
            abstractionA.Operation();

            Default.IAbstraction abstractionB = new Default.RefinedAbstraction(new Default.ConcreteImplementorB());
            abstractionB.Operation();

            #endregion

            #region Situation


            Situation.IStore store = new Situation.Store(new Situation.Cash());
            store.Pay(100);

            Situation.IStore onlineStore = new Situation.OnlineStore(new Situation.ApplePay());
            onlineStore.Pay(200);

            #endregion

            Console.ReadLine();
        }
    }
}
