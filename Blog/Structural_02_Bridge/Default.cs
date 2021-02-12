using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_02_Bridge
{
    public class Default
    {
        /// <summary>
        /// 包含 Implementor 的抽象介面，在此使用 interface
        /// </summary>
        public interface IAbstraction
        {
            IImplementor Implementor { get; }

            void Operation();
        }

        /// <summary>
        /// 操作的介面
        /// </summary>
        public interface IImplementor
        {
            void Operation();
        }

        /// <summary>
        /// 實作 IAbstraction 並在建構子取得 IImplementor 實作
        /// </summary>
        public class RefinedAbstraction : IAbstraction
        {
            public IImplementor Implementor { get; }

            public RefinedAbstraction(IImplementor implementor)
            {
                Implementor = implementor;
            }

            public void Operation()
            {
                Implementor.Operation();
            }
        }

        /// <summary>
        /// IImplementor 的實作 A
        /// </summary>
        public class ConcreteImplementorA : IImplementor
        {
            public void Operation()
            {
                Console.WriteLine("ConcreteImplementorA Operation");
            }
        }

        /// <summary>
        /// IImplementor 的實作 B
        /// </summary>
        public class ConcreteImplementorB : IImplementor
        {
            public void Operation()
            {
                Console.WriteLine("ConcreteImplementorB Operation");
            }
        }
    }
}
