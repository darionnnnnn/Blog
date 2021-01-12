using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_04_Prototype
{
    public class Situation
    {
        /// <summary>
        /// 分店資訊介面
        /// </summary>
        public interface IStore
        {
            string StoreId { get; set; }

            string InStockData { get; set; }

            public IStore Clone(string storeId);
        }

        /// <summary>
        /// 分店資訊實作
        /// </summary>
        public class Store : IStore
        {
            public string StoreId { get; set; }

            public string InStockData { get; set; }

            public Store(string storeId)
            {
                StoreId = storeId;
            }

            public void GetInStockData()
            {
                InStockData = "庫存量";

                Console.WriteLine($"取得 {InStockData}");
            }

            // Returns a shallow copy
            public IStore Clone(string storeId)
            {
                var clone = (IStore) this.MemberwiseClone();
                clone.StoreId = storeId;
                return clone;
            }
        }
    }
}
