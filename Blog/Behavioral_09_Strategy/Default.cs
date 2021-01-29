using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_09_Strategy
{
    public class Default
    {
        /// <summary>
        /// 策略介面
        /// </summary>
        public interface IStrategy
        {
            public void AlgorithmInterface();
        }

        /// <summary>
        /// 策略實作 A
        /// </summary>
        public class ConcreteStrategyA : IStrategy
        {
            public void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
            }
        }

        /// <summary>
        /// 策略實作 B
        /// </summary>
        public class ConcreteStrategyB : IStrategy
        {
            public void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
            }
        }

        /// <summary>
        /// 策略實作 C
        /// </summary>
        public class ConcreteStrategyC : IStrategy
        {
            public void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
            }
        }

        /// <summary>
        /// 使用演算法的物件
        /// </summary>
        public class Context
        {
            private IStrategy _strategy;

            public Context(IStrategy strategy)
            {
                _strategy = strategy;
            }

            public void ContextInterface()
            {
                _strategy.AlgorithmInterface();
            }
        }
    }
}
