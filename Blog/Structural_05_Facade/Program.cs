using System;

namespace Structural_05_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.Facade facade = new Default.Facade();
            //
            // facade.MethodA();
            // facade.MethodB();

            #endregion

            #region Situation

            Situation.Facade facade = new Situation.Facade();

            var northernTaiwanInStock = facade.GetNorthernTaiwanInStock();
            Console.WriteLine($" ---- 北台灣庫存：{northernTaiwanInStock}");

            var taiwanInStock = facade.GetTaiwanInStock();
            Console.WriteLine($" ---- 全台灣庫存：{taiwanInStock}");

            #endregion
            Console.ReadLine();
        }
    }
}
