using System;

namespace Behavioral_09_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.Context context;
            //
            // context = new Default.Context(new Default.ConcreteStrategyA());
            // context.ContextInterface();
            //
            // context = new Default.Context(new Default.ConcreteStrategyB());
            // context.ContextInterface();
            //
            // context = new Default.Context(new Default.ConcreteStrategyC());
            // context.ContextInterface();

            #endregion

            #region Situation

            Situation.GetPrice context;
            
            context = new Situation.GetPrice(new Situation.TenPercentOff());
            context.Calculate(1600);
            Console.WriteLine("\n");
            context = new Situation.GetPrice(new Situation.ThousandGet100CashBack());
            context.Calculate(1100);
            Console.WriteLine("\n");
            context = new Situation.GetPrice(new Situation.Giveaway());
            context.Calculate(600);

            #endregion

            Console.ReadLine();
        }
    }
}
