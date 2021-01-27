using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_07_Observer
{
    public class Situation
    {
        public enum StockType
        {
            OutOfStock,
            InStock
        }

        /// <summary>
        /// 商品抽象類別，實作加入 & 移除觀察者
        /// </summary>
        public abstract class Product
        {
            private List<IObserver> _observers = new List<IObserver>();

            public void Attach(IObserver observer)
            {
                _observers.Add(observer);
            }

            public void Detach(IObserver observer)
            {
                _observers.Remove(observer);
            }

            public void Notify()
            {
                foreach (IObserver observer in _observers)
                {
                    observer.Update();
                }
            }
        }

        public interface IProduct
        {
            string Name { get; }
            StockType StockType { get; set; }
        }

        /// <summary>
        /// 商品實作
        /// </summary>
        public class AppleProduct : Product, IProduct
        {
            public string Name { get; }
            public StockType StockType { get; set; }

            public AppleProduct(string name)
            {
                Name = name;
            }
        }

        /// <summary>
        /// 觀察者介面
        /// </summary>
        public interface IObserver
        {
            void Update();
        }

        /// <summary>
        /// 觀察者實作
        /// </summary>
        public class ConcreteObserver<T> : IObserver
        where T : IProduct
        {
            private T Product { get; }
            private string _customerName;
            private StockType _stockType;

            public ConcreteObserver(T product, string customerName)
            {
                Product = product;
                _customerName = customerName;
            }

            public void Update()
            {
                _stockType = Product.StockType;
                Console.WriteLine($"Hi {_customerName}, {Product.Name} is {_stockType}.");
            }
        }
    }
}
