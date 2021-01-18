using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_05_Facade
{
    public class Situation
    {
        /// <summary>
        /// 台北庫存
        /// </summary>
        public class TaipeiInStock
        {
            public int GetInStock(int parameterA, string parameterB)
            {
                Console.WriteLine("台北庫存：100");

                return 100;
            }
        }

        /// <summary>
        /// 桃園庫存
        /// </summary>
        public class TaoyuanInStock
        {
            public int GetInStock(int parameterA, string parameterB)
            {
                Console.WriteLine("桃園庫存：80");

                return 80;
            }
        }

        /// <summary>
        /// 台中庫存
        /// </summary>
        public class TaichungInStock
        {
            public int GetInStock(bool parameterC)
            {
                Console.WriteLine("台中庫存：120");

                return 120;
            }
        }

        /// <summary>
        /// 台南庫存
        /// </summary>
        public class TainanInStock
        {
            public int GetInStock()
            {
                Console.WriteLine("台南庫存：200");

                return 200;
            }
        }

        /// <summary>
        /// Facade 整合各地庫存加總後回傳
        /// </summary>
        public class Facade
        {
            private TaipeiInStock _taipeiInStock;
            private TaoyuanInStock _taoyuanInStock;
            private TaichungInStock _taichungInStock;
            private TainanInStock _tainanInStock;

            public Facade()
            {
                _taipeiInStock = new TaipeiInStock();
                _taoyuanInStock = new TaoyuanInStock();
                _taichungInStock = new TaichungInStock();
                _tainanInStock = new TainanInStock();
            }

            // 取得北台灣庫存
            public int GetNorthernTaiwanInStock()
            {
                Console.WriteLine("\n ---- 取得北台灣庫存 ---- ");
                var taipei = _taipeiInStock.GetInStock(default, default);
                var taoyuan = _taoyuanInStock.GetInStock(default, default);

                return taipei + taoyuan;
            }

            // 取得全台灣庫存
            public int GetTaiwanInStock()
            {
                Console.WriteLine("\n ---- 取得全台灣庫存 ---- ");
                var taipei = _taipeiInStock.GetInStock(default, default);
                var taoyuan = _taoyuanInStock.GetInStock(default, default);
                var taichung = _taichungInStock.GetInStock(default);
                var tainan = _tainanInStock.GetInStock();

                return taipei + taoyuan + taichung + tainan;
            }
        }
    }
}
