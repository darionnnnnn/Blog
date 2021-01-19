using System;

namespace Structural_06_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            int extrinsicstate = 0;

            // Default.FlyweightFactory factory = new Default.FlyweightFactory();
            //
            // Default.IFlyweight flyweight_1 = factory.GetFlyweight("One");
            // flyweight_1.Operation(++extrinsicstate);
            //
            // Default.IFlyweight flyweight_2 = factory.GetFlyweight("Two");
            // flyweight_2.Operation(++extrinsicstate);
            //
            // Default.IFlyweight flyweight_3 = factory.GetFlyweight("Three");
            // flyweight_3.Operation(++extrinsicstate);

            #endregion

            #region Situation

            Situation.ExchangeRatesFactory factory = new Situation.ExchangeRatesFactory();
            int amount = 100;

            Situation.IExchangeRates converter_JPY = factory.GetConverter(Situation.CurrencyType.JPY);
            var jpy = converter_JPY.Converter(amount);

            Console.WriteLine($"TWD 轉換至 JPY：{amount} → {jpy}");

            Situation.IExchangeRates converter_USD = factory.GetConverter(Situation.CurrencyType.USD);
            var usd = converter_USD.Converter(amount);

            Console.WriteLine($"TWD 轉換至 USD：{amount} → {usd}");

            Situation.IExchangeRates converter_EUR = factory.GetConverter(Situation.CurrencyType.EUR);
            var eur = converter_EUR.Converter(amount);

            Console.WriteLine($"TWD 轉換至 EUR：{amount} → {eur}");


            #endregion

            Console.ReadLine();
        }
    }
}
