using System;
using System.Collections.Generic;

namespace Creational_01_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // var creators = new List<Default.ICreator>
            //                {
            //                    new Default.ConcreteCreatorA(),
            //                    new Default.ConcreteCreatorB()
            //                };
            //
            // foreach (var creator in creators)
            // {
            //     Default.IProduct product = creator.FactoryMethod();
            //     Console.WriteLine($"Created {product.GetType().Name}");
            // }

            #endregion

            #region Situation

            // var creators = new List<Situation.ICreator_Payment>
            //                {
            //                    new Situation.Creator_Cash(),
            //                    new Situation.Creator_ApplePay()
            //                };
            //
            // foreach (var creator in creators)
            // {
            //     Situation.IPayment payment = creator.FactoryMethod();
            //     Console.WriteLine($"{payment.Pay(10)}");
            // }

            #endregion

            #region SimpleFactory

            foreach (SimpleFactory.PayType payType in Enum.GetValues(typeof(SimpleFactory.PayType)))
            {
                SimpleFactory.IPayment payment = SimpleFactory.GetPayment(payType);
                Console.WriteLine($"{payment.Pay(10)}");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
