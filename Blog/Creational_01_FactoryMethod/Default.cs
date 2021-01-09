using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_01_FactoryMethod
{
    public class Default
    {
        /// <summary>
        /// 原有邏輯的介面
        /// </summary>
        public interface IProduct
        {
        }

        /// <summary>
        /// 原有邏輯的實作 A
        /// </summary>
        public class ConcreteProductA : IProduct
        {
        }

        /// <summary>
        /// 原有邏輯的實作 B
        /// </summary>
        public class ConcreteProductB : IProduct
        {
        }

        /// <summary>
        /// 工廠方法的介面
        /// </summary>
        public interface ICreator
        {
            public IProduct FactoryMethod();
        }

        /// <summary>
        /// 工廠方法的實作 A
        /// </summary>
        public class ConcreteCreatorA : ICreator
        {
            public IProduct FactoryMethod()
            {
                return new ConcreteProductA();
            }
        }

        /// <summary>
        /// 工廠方法的實作 B
        /// </summary>
        public class ConcreteCreatorB : ICreator
        {
            public IProduct FactoryMethod()
            {
                return new ConcreteProductB();
            }
        }
    }
}
