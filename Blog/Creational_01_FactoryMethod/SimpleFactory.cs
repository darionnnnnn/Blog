using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_01_FactoryMethod
{
    public class SimpleFactory
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
        /// 付款方式類型
        /// </summary>
        public enum PayType
        {
            Cash,
            ApplePay
        }

        /// <summary>
        /// 簡單工廠方法
        /// </summary>
        /// <param name="payType"></param>
        /// <returns></returns>
        public static IPayment GetPayment(PayType payType)
        {
            return payType switch
                   {
                       PayType.Cash     => new Cash(),
                       PayType.ApplePay => new ApplePay(),
                       _                => null
                   };
        }
    }
}
