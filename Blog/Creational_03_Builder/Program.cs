using System;

namespace Creational_03_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.Director director = new Default.Director();
            //
            // var builder1 = new Default.ConcreteBuilder1();
            // var builder2 = new Default.ConcreteBuilder2();
            //
            // director.Construct(builder1);
            // var product1 = builder1.GetResult();
            // product1.Show();
            //
            // director.Construct(builder2);
            // var product2 = builder2.GetResult();
            // product2.Show();

            #endregion

            #region Situation

            Situation.Director director = new Situation.Director();
            
            var cashBuilder = new Situation.CashBuilder();
            var applePayBuilder = new Situation.ApplePayBuilder();
            
            director.Construct(cashBuilder);
            var cash = cashBuilder.GetPayment();
            cash.Pay(100);
            
            director.Construct(applePayBuilder);
            var applePay = applePayBuilder.GetPayment();
            applePay.Pay(100);

            #endregion


            Console.ReadLine();
        }

    }
}
