using System;

namespace Structural_07_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.Proxy proxy = new Default.Proxy();
            // proxy.Request();

            #endregion

            #region Situation

            Situation.Proxy proxyStoreManager = new Situation.Proxy(Situation.Position.StoreManager);
            proxyStoreManager.GetReport();

            Console.WriteLine($"\n");

            Situation.Proxy proxyClerk = new Situation.Proxy(Situation.Position.Clerk);
            proxyClerk.GetReport();

            #endregion

            Console.ReadLine();
        }
    }
}
