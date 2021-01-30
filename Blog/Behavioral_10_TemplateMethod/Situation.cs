using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_10_TemplateMethod
{
    public class Situation
    {
        /// <summary>
        /// 取得客戶訂單邏輯的抽象類別
        /// </summary>
        public abstract class CustomerOrderInfo
        {
            public abstract void GetOrderInfo();

            public void TemplateMethod()
            {
                GetOrderInfo();
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// 從資料庫 A 取得訂單資訊
        /// </summary>
        public class OrderInDBA : CustomerOrderInfo
        {
            public override void GetOrderInfo()
            {
                Console.WriteLine("從 DB A 取得半年內訂單資訊");
            }
        }

        /// <summary>
        /// 從資料庫 B 取得訂單資訊
        /// </summary>
        public class OrderInDBB : CustomerOrderInfo
        {
            public override void GetOrderInfo()
            {
                Console.WriteLine("從 DB B 取得超過半年以上訂單資訊");
            }
        }
    }
}
