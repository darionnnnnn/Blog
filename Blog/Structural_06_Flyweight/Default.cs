using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Structural_06_Flyweight
{
    public class Default
    {
        /// <summary>
        /// 享元介面
        /// </summary>
        public interface IFlyweight
        {
            void Operation(int extrinsicState);
        }

        /// <summary>
        /// 享元工廠
        /// </summary>
        public class FlyweightFactory
        {
            private Hashtable flyweights = new Hashtable();

            public FlyweightFactory()
            {
                flyweights.Add("One", new ConcreteFlyweight());
                flyweights.Add("Two", new ConcreteFlyweight());
                flyweights.Add("Three", new ConcreteFlyweight());
            }

            public IFlyweight GetFlyweight(string key)
            {
                return ((IFlyweight)flyweights[key]);
            }
        }

        /// <summary>
        /// 享元實作
        /// </summary>
        public class ConcreteFlyweight : IFlyweight
        {
            public void Operation(int extrinsicState)
            {
                Console.WriteLine($"ConcreteFlyweight: {extrinsicState}");
            }
        }
    }
}
