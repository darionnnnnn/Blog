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
            public void Construct(Builder builder)
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
        /// 建造者方法的父類別或介面
        /// </summary>
        public abstract class Builder
        {
            // 折扣
            public abstract void Discount();
            // 紅利點數
            public abstract void RewardPoints();
            // 贈品
            public abstract void Giveaway();

            public abstract Product GetPayment();
        }

        /// <summary>
        /// 建造者方法的現金實作
        /// </summary>
        public class CashBuilder : Builder
        {
            private Product _product = new Product();

            public override void Discount()
            {
                _product.Add("Cash 不打折");
                _product.SetDiscount(1);
            }

            public override void RewardPoints()
            {
                _product.Add("Cash 集點");
            }

            public override void Giveaway()
            {
                _product.Add("Cash 送馬克杯");
            }

            public override Product GetPayment()
            {
                return _product;
            }
        }

        /// <summary>
        /// 建造者方法的 ApplePay 實作
        /// </summary>
        public class ApplePayBuilder : Builder
        {
            private Product _product = new Product();

            public override void Discount()
            {
                _product.Add("ApplePay 九折");
                _product.SetDiscount(0.9);
            }

            public override void RewardPoints()
            {
                _product.Add("ApplePay 集點");
            }

            public override void Giveaway()
            {
                _product.Add("ApplePay 無贈品");
            }

            public override Product GetPayment()
            {
                return _product;
            }
        }

        /// <summary>
        /// 正在構造的複雜對象
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
