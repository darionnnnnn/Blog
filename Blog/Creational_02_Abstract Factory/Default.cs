using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_02_AbstractFactory
{
    public class Default
    {
        /// <summary>
        /// 抽象工廠介面
        /// </summary>
        public interface IFactory
        {
            IProductA CreateProductA();
            IProductB CreateProductB();
        }


        /// <summary>
        /// 抽象工廠實作 1
        /// </summary>
        public class ConcreteFactory1 : IFactory
        {
            public IProductA CreateProductA()
            {
                return new ProductA1();
            }
            public IProductB CreateProductB()
            {
                return new ProductB1();
            }
        }

        /// <summary>
        /// 抽象工廠實作 2
        /// </summary>
        public class ConcreteFactory2 : IFactory
        {
            public IProductA CreateProductA()
            {
                return new ProductA2();
            }
            public IProductB CreateProductB()
            {
                return new ProductB2();
            }
        }

        /// <summary>
        /// 原有邏輯的介面 A
        /// </summary>
        public interface IProductA
        {
        }

        /// <summary>
        /// 原有邏輯的介面 B
        /// </summary>
        public interface IProductB
        {
            void Interact(IProductA a);
        }


        /// <summary>
        /// 原有邏輯的介面 A 實作 A1
        /// </summary>
        public class ProductA1 : IProductA
        {
        }

        /// <summary>
        /// 原有邏輯的介面 B 實作 B1
        /// </summary>
        class ProductB1 : IProductB
        {
            public void Interact(IProductA a)
            {
                Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
            }
        }

        /// <summary>
        /// 原有邏輯的介面 A 實作 A2
        /// </summary>
        public class ProductA2 : IProductA
        {
        }

        /// <summary>
        /// 原有邏輯的介面 B 實作 B2
        /// </summary>
        class ProductB2 : IProductB
        {
            public void Interact(IProductA a)
            {
                Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
            }
        }

        /// <summary>
        /// 使用 AbstractFactory & AbstractProductA/B 的介面
        /// </summary>
        public class Client
        {
            private IProductA _productA;
            private IProductB _productB;

            // Constructor
            public Client(IFactory factory)
            {
                _productB = factory.CreateProductB();
                _productA = factory.CreateProductA();
            }

            public void Run()
            {
                _productB.Interact(_productA);
            }
        }
    }
}
