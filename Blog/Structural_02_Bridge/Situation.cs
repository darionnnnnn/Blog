using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_02_Bridge
{
    public class Situation
    {
        /// <summary>
        /// 門市介面
        /// </summary>
        public interface IStore
        {
            void Pay(int amount);
        }

        /// <summary>
        /// 付款介面
        /// </summary>
        public interface IPayment
        {
            void Pay(int amount);
        }

        /// <summary>
        /// 實作實體門市
        /// </summary>
        public class Store : IStore
        {
            private IPayment _Payment { get; }

            public Store(IPayment payment)
            {
                _Payment = payment;
            }

            public void Pay(int amount)
            {
                Console.WriteLine($"在實體門市");
                _Payment.Pay(amount);
            }
        }

        /// <summary>
        /// 實作線上商城
        /// </summary>
        public class OnlineStore : IStore
        {
            private IPayment _Payment { get; }

            public OnlineStore(IPayment payment)
            {
                _Payment = payment;
            }

            public void Pay(int amount)
            {
                Console.WriteLine($"在線上商城");

                _Payment.Pay(amount);
            }
        }

        /// <summary>
        /// 實作以現金付款
        /// </summary>
        public class Cash : IPayment
        {
            public void Pay(int amount)
            {
                Console.WriteLine($"使用 現金 付款 {amount} 元");
            }
        }

        /// <summary>
        /// 實作以 ApplePay 付款
        /// </summary>
        public class ApplePay : IPayment
        {
            public void Pay(int amount)
            {
                Console.WriteLine($"使用 ApplePay 付款 {amount} 元");
            }
        }
    }
}
