using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_01_FactoryMethod
{
    public class Situation
    {
        /// <summary>
        /// 付款介面
        /// </summary>
        public interface IPayment
        {
            string Pay(int amount);
        }

        /// <summary>
        /// 實作以現金付款
        /// </summary>
        public class Cash : IPayment
        {
            public string Pay(int amount)
            {
                return $"使用 現金 付款 {amount} 元";
            }
        }

        /// <summary>
        /// 實作以 ApplePay 付款
        /// </summary>
        public class ApplePay : IPayment
        {
            public string Pay(int amount)
            {
                return $"使用 ApplePay 付款 {amount} 元";
            }
        }

        /// <summary>
        /// 工廠介面
        /// </summary>
        public interface ICreator_Payment
        {
            public IPayment FactoryMethod();
        }

        /// <summary>
        /// 實作工廠介面回傳現金付款實體
        /// </summary>
        public class Creator_Cash : ICreator_Payment
        {
            public IPayment FactoryMethod()
            {
                return new Cash();
            }
        }

        /// <summary>
        /// 實作工廠介面回傳 ApplePay 付款實體
        /// </summary>
        public class Creator_ApplePay : ICreator_Payment
        {
            public IPayment FactoryMethod()
            {
                return new ApplePay();
            }
        }
    }
}
