using System;

namespace Creational_06_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.ITarget target = new Default.Adapter();
            // target.Request();

            #endregion

            #region Situation

            Situation.IInStock inStock = new Situation.Adapter();
            var data = inStock.GetInStockData();

            Console.WriteLine(data);

            #endregion

            Console.ReadLine();
        }
    }
}
