using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_05_Singleton
{
    public class Situation
    {
        /// <summary>
        /// Singleton 實體
        /// </summary>
        public class InStockModel
        {
            private static InStockModel _instance;

            protected InStockModel()
            {
                Console.WriteLine($"Get in stock data by API.");
            }

            public static InStockModel Instance()
            {
                // 使用延遲載入，此方式並非 thread safe
                return _instance ??= new InStockModel();
            }
        }
    }

}
