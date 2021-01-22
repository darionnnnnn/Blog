using System;

namespace Behavioral_02_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            Default.Receiver receiver = new Default.Receiver();
            Default.ICommand command = new Default.ConcreteCommand(receiver);
            Default.Invoker invoker = new Default.Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            #endregion

            #region Situation

            // Situation.Employee employee = new Situation.Employee();
            // Situation.IOrder orderCoffee = new Situation.OrderCoffee(employee);
            // Situation.IOrder orderBoxedMeal = new Situation.OrderBoxedMeal(employee);
            // Situation.Invoker invoker = new Situation.Invoker();
            //
            // invoker.SetOrder(orderCoffee);
            // invoker.ExecuteCommand();
            // invoker.SetOrder(orderBoxedMeal);
            // invoker.ExecuteCommand();

            #endregion

            Console.ReadLine();
        }
    }
}
