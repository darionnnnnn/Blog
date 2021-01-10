using System;
using Creational_02_Abstract_Factory;

namespace Creational_02_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.IFactory factory1 = new Default.ConcreteFactory1();
            // Default.Client client1 = new Default.Client(factory1);
            // client1.Run();
            //
            // Default.IFactory factory2 = new Default.ConcreteFactory2();
            // Default.Client client2 = new Default.Client(factory2);
            // client2.Run();

            #endregion


            #region Situation

            Situation.IFactory cashFactory = new Situation.CashFactory();
            Situation.Client cashClient = new Situation.Client(cashFactory);
            cashClient.Pay(100);

            Situation.IFactory applePayFactory = new Situation.ApplePayFactory();
            Situation.Client applePayClient = new Situation.Client(applePayFactory);
            applePayClient.Pay(100);

            #endregion

            Console.ReadLine();
        }
    }
}
