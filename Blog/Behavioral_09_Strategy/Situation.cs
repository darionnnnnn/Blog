using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_09_Strategy
{
    public class Situation
    {
        /// <summary>
        /// 策略介面
        /// </summary>
        public interface IStrategy
        {
            public int Discount(int amount);
        }

        /// <summary>
        /// 結帳金額九折
        /// </summary>
        public class TenPercentOff : IStrategy
        {
            public int Discount(int amount)
            {
                Console.WriteLine("結帳金額九折");
                return (int)(amount * 0.9);
            }
        }

        /// <summary>
        /// 滿千折百
        /// </summary>
        public class ThousandGet100CashBack : IStrategy
        {
            public int Discount(int amount)
            {
                Console.WriteLine("滿千折百");
                return amount >= 1000 ? amount - 100 : amount;
            }
        }

        /// <summary>
        /// 送贈品
        /// </summary>
        public class Giveaway : IStrategy
        {
            public int Discount(int amount)
            {
                Console.WriteLine("送贈品");

                return amount;
            }
        }

        /// <summary>
        /// 依據使用者選擇折扣計算結帳金額
        /// </summary>
        public class GetPrice
        {
            private IStrategy _strategy;

            public GetPrice(IStrategy strategy)
            {
                _strategy = strategy;
            }

            public void Calculate(int amount)
            {
                Console.WriteLine($"原價：{amount}");

                var newAmount = _strategy.Discount(amount);

                Console.WriteLine($"折扣價：{newAmount}");
            }
        }
    }
}
