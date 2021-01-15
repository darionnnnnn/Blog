using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Structural_01_Adapter
{
    public class Situation
    {
        /// <summary>
        /// 定義呼叫端使用的接口
        /// </summary>
        public interface IInStock
        {
            string GetInStockData();
        }

        /// <summary>
        /// 實作 Adapter
        /// </summary>
        public class Adapter : IInStock
        {
            private InStockService _inStockService = new InStockService();

            public string GetInStockData()
            {
                var inStockData = _inStockService.GetInStockData();

                return JsonSerializer.Serialize(inStockData);
            }
        }

        /// <summary>
        /// 實作端的接口
        /// </summary>
        public class InStockService
        {
            public List<InStockModel> GetInStockData()
            {
                Console.WriteLine("Called InStockService GetInStockData()");

                var inStockData = new List<InStockModel>
                                  {
                                      new InStockModel{Id = 1, Name = "AA", InStock = 100},
                                      new InStockModel{Id = 2, Name = "BB", InStock = 200},
                                      new InStockModel{Id = 3, Name = "CC", InStock = 300},

                                  };

                return inStockData;
            }
        }

        /// <summary>
        /// 庫存資料格式
        /// </summary>
        public class InStockModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int InStock { get; set; }
        }
    }
}
