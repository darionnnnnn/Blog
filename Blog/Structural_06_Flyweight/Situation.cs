using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Structural_06_Flyweight
{
    public class Situation
    {
        /// <summary>
        /// 貨幣類別
        /// </summary>
        public enum CurrencyType
        {
            TWD,
            JPY,
            USD,
            EUR,
        }

        /// <summary>
        /// 匯率工廠
        /// </summary>
        public class ExchangeRatesFactory
        {
            private Hashtable flyweights = new Hashtable();

            public ExchangeRatesFactory()
            {
                flyweights.Add(CurrencyType.TWD, new ExchangeRates((decimal)1));
                flyweights.Add(CurrencyType.JPY, new ExchangeRates((decimal)0.273));
                flyweights.Add(CurrencyType.USD, new ExchangeRates((decimal)28.235));
                flyweights.Add(CurrencyType.EUR, new ExchangeRates((decimal)34.35));
            }

            public IExchangeRates GetConverter(CurrencyType currencyType)
            {
                return ((IExchangeRates)flyweights[currencyType]);
            }
        }

        /// <summary>
        /// 轉換介面
        /// </summary>
        public interface IExchangeRates
        {
            public decimal Converter(int amount);
        }

        /// <summary>
        /// 傳換實作
        /// </summary>
        public class ExchangeRates : IExchangeRates
        {
            private decimal _CashRate { get; }
            public ExchangeRates(decimal cashRate)
            {
                _CashRate = cashRate;
            }
            public decimal Converter(int amount)
            {
                var newAmount = amount / _CashRate;
                return decimal.Parse(newAmount.ToString("#0.00"));
            }
        }
    }
}
