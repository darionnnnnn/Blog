using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_03_Builder
{
    public class Situation
    {
        /// <summary>
        /// 定義建造的流程細節
        /// </summary>
        public class Director
        {
            public void Construct(IBuilder builder)
            {
                // 加入折扣
                builder.Discount();
                // 加入紅利點數
                builder.RewardPoints();
                // 加入贈品
                builder.Giveaway();
            }
        }

        /// <summary>
        /// 建造者方法的介面
        /// </summary>
        public interface IBuilder
        {
            // 折扣
            void Discount();
            // 紅利點數
            void RewardPoints();
            // 贈品
            void Giveaway();

            Product GetPayment();
        }

        /// <summary>
        /// 建造者方法的現金實作
        /// </summary>
        public class CashBuilder : IBuilder
        {
            private Product _product = new Product();

            public void Discount()
            {
                _product.Add("Cash 不打折");
                _product.SetDiscount(1);
            }

            public void RewardPoints()
            {
                _product.Add("Cash 集點");
            }

            public void Giveaway()
            {
                _product.Add("Cash 送馬克杯");
            }

            public Product GetPayment()
            {
                return _product;
            }
        }

        /// <summary>
        /// 建造者方法的 ApplePay 實作
        /// </summary>
        public class ApplePayBuilder : IBuilder
        {
            private Product _product = new Product();

            public void Discount()
            {
                _product.Add("ApplePay 九折");
                _product.SetDiscount(0.9);
            }

            public void RewardPoints()
            {
                _product.Add("ApplePay 集點");
            }

            public void Giveaway()
            {
                _product.Add("ApplePay 無贈品");
            }

            public Product GetPayment()
            {
                return _product;
            }
        }

        /// <summary>
        /// 正在構造的複雜物件
        /// </summary>
        public class Product
        {
            private List<string> _parts = new List<string>();

            private double _discount { get; set; }

            public void SetDiscount(double discount)
            {
                _discount = discount;
            }

            public void Add(string part)
            {
                _parts.Add(part);
            }

            public void Pay(int amount)
            {
                Console.WriteLine("\n-------");

                foreach (string part in _parts)
                {
                    Console.WriteLine(part);
                }

                Console.WriteLine($"應收金額：{(int)(amount * _discount)} 元");
            }
        }
    }
}
