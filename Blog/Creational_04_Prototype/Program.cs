using System;

namespace Creational_04_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.ConcretePrototype prototype = new Default.ConcretePrototype("Test StoreId");
            // Default.ConcretePrototype clone = (Default.ConcretePrototype)prototype.Clone();
            // Console.WriteLine($"Cloned: {clone.Id}");

            #endregion

            #region Situation

            Situation.Store store = new Situation.Store("Taipei");
            store.GetInStockData();

            Situation.Store clone = (Situation.Store)store.Clone("Tainan");
            Console.WriteLine($"Store StoreId: {store.StoreId}");
            Console.WriteLine($"Store InStockData: {store.InStockData}");
            Console.WriteLine($"Clone StoreId: {clone.StoreId}");
            Console.WriteLine($"Clone InStockData: {clone.InStockData}");

            #endregion

            Console.ReadLine();
        }
    }
}
