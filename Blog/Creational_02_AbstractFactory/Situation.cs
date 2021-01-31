using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_02_AbstractFactory
{
    public class Situation
    {
        /// <summary>
        /// 抽象工廠介面
        /// </summary>
        public interface IFactory
        {
            IPayment CreatePayment();
            IDiscount CreateDiscount();
        }

        /// <summary>
        /// 現金付款工廠
        /// </summary>
        public class CashFactory : IFactory
        {
            public IPayment CreatePayment()
            {
                return new Cash();
            }
            public IDiscount CreateDiscount()
            {
                return new DiscountCash();
            }
        }

        /// <summary>
        /// ApplePay 付款工廠
        /// </summary>
        public class ApplePayFactory : IFactory
        {
            public IPayment CreatePayment()
            {
                return new ApplePay();
            }
            public IDiscount CreateDiscount()
            {
                return new DiscountApplePay();
            }
        }

        /// <summary>
        /// 付款方式介面
        /// </summary>
        public interface IPayment
        {
            void Pay(int amount);
        }

        /// <summary>
        /// 折扣介面
        /// </summary>
        public interface IDiscount
        {
            void Interact(IPayment payment, int amount);
        }

        /// <summary>
        /// 實作付款介面：現金
        /// </summary>
        public class Cash : IPayment
        {
            public void Pay(int amount)
            {
                Console.WriteLine($"使用 現金 付款 {amount} 元");
            }
        }

        /// <summary>
        /// 實作折扣介面：現金
        /// </summary>
        class DiscountCash : IDiscount
        {
            public void Interact(IPayment payment, int amount)
            {
                // 使用現金無折扣
                payment.Pay(amount);
            }
        }

        /// <summary>
        /// 實作付款介面：ApplePay
        /// </summary>
        public class ApplePay : IPayment
        {
            public void Pay(int amount)
            {
                Console.WriteLine($"使用 ApplePay 付款 {amount} 元");
            }
        }

        /// <summary>
        /// 實作折扣介面：ApplePay
        /// </summary>
        class DiscountApplePay : IDiscount
        {
            public void Interact(IPayment payment, int amount)
            {
                // 使用 ApplePay 打九折
                var newAmount = (int)(amount * 0.9);
                payment.Pay(newAmount);
            }
        }

        /// <summary>
        /// 取得付款 & 折扣實作，並可進行付款動作
        /// </summary>
        public class Client
        {
            private IPayment _payment;
            private IDiscount _discount;

            public Client(IFactory factory)
            {
                _discount = factory.CreateDiscount();
                _payment = factory.CreatePayment();
            }

            public void Pay(int amount)
            {
                _discount.Interact(_payment, amount);
            }
        }
    }
}
