using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_04_Decorator
{
    public class Situation
    {
        /// <summary>
        /// 計算售價抽象類別
        /// </summary>
        public abstract class Calculation
        {
            public abstract int Price();
        }

        /// <summary>
        /// 計算售價實作
        /// </summary>
        public class ConcreteCalculation : Calculation
        {
            private int _Price { get; }

            public ConcreteCalculation(int price)
            {
                _Price = price;
            }

            public override int Price()
            {
                Console.WriteLine($"結帳金額(原價)：{_Price}");

                return _Price;
            }
        }

        /// <summary>
        /// 裝飾者抽象類別，繼承被裝飾者抽象類別
        /// </summary>
        public abstract class Decorator : Calculation
        {
            protected Calculation Calculation;

            public void SetComponent(Calculation calculation)
            {
                this.Calculation = calculation;
            }

            public override int Price()
            {
                return Calculation?.Price()?? 0;
            }
        }

        /// <summary>
        /// 全面九折
        /// </summary>
        public class AllTenPercentOff : Decorator
        {
            public override int Price()
            {
                var getPrice = base.Price();

                var newPrice = (int) (getPrice * 0.9);

                Console.WriteLine($"結帳金額(全面九折)：{newPrice}");

                return newPrice;
            }
        }

        /// <summary>
        /// 滿千折百無上限
        /// </summary>
        public class Every1000Get100CashBack : Decorator
        {
            public override int Price()
            {
                var getPrice = base.Price();
                var discountTimes = (int)Math.Floor((decimal)(getPrice / 1000));
                var newPrice = getPrice - (100 * discountTimes);

                Console.WriteLine($"結帳金額(滿千折百無上限)：{newPrice}");

                return newPrice;
            }
        }
    }
}
