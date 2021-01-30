using System;

namespace Behavioral_10_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.AbstractClass aA = new Default.ConcreteClassA();
            // aA.TemplateMethod();
            //
            // Default.AbstractClass aB = new Default.ConcreteClassB();
            // aB.TemplateMethod();

            #endregion

            #region Situation

            Situation.CustomerOrderInfo orderInSixMonth = new Situation.OrderInDBA();
            orderInSixMonth.TemplateMethod();

            Situation.CustomerOrderInfo orderOverSixMonth = new Situation.OrderInDBB();
            orderOverSixMonth.TemplateMethod();

            #endregion

            Console.ReadLine();
        }
    }
}
