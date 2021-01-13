using System;

namespace Creational_05_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.Singleton singletonA = Default.Singleton.Instance();
            // Default.Singleton singletonB = Default.Singleton.Instance();
            //
            // if (singletonA == singletonB)
            // {
            //     Console.WriteLine("\nSame instance");
            // }

            #endregion

            #region Situation

            Situation.InStockModel inStockModelA = Situation.InStockModel.Instance();
            Situation.InStockModel inStockModelB = Situation.InStockModel.Instance();
            
            if (inStockModelA == inStockModelB)
            {
                Console.WriteLine("\nSame instance");
            }

            #endregion

            Console.ReadLine();
        }

    }
}
