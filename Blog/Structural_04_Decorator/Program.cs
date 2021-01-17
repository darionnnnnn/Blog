using System;

namespace Structural_04_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.ConcreteComponent component = new Default.ConcreteComponent();
            // Default.ConcreteDecoratorA decoratorA = new Default.ConcreteDecoratorA();
            // Default.ConcreteDecoratorB decoratorB = new Default.ConcreteDecoratorB();
            //
            // decoratorA.SetComponent(component);
            // decoratorB.SetComponent(decoratorA);
            //
            // decoratorB.Operation();

            #endregion

            #region Situation

            Situation.ConcreteCalculation calculation = new Situation.ConcreteCalculation(5000);
            Situation.AllTenPercentOff allTenPercentOff = new Situation.AllTenPercentOff();
            Situation.Every1000Get100CashBack every1000Get100CashBack = new Situation.Every1000Get100CashBack();

            allTenPercentOff.SetComponent(calculation);
            every1000Get100CashBack.SetComponent(allTenPercentOff);

            every1000Get100CashBack.Price();

            #endregion

            Console.ReadLine();
        }
    }
}
