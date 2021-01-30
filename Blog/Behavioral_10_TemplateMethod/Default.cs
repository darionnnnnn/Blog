using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_10_TemplateMethod
{
    public class Default
    {
        /// <summary>
        /// 定義演算法步驟的抽象類別
        /// </summary>
        public abstract class AbstractClass
        {
            public abstract void PrimitiveOperation1();
            public abstract void PrimitiveOperation2();

            public void TemplateMethod()
            {
                PrimitiveOperation1();
                PrimitiveOperation2();
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// 實作演算法特定步驟 A
        /// </summary>
        public class ConcreteClassA : AbstractClass
        {
            public override void PrimitiveOperation1()
            {
                Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
            }
            public override void PrimitiveOperation2()
            {
                Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
            }
        }

        /// <summary>
        /// 實作演算法特定步驟 B
        /// </summary>
        public class ConcreteClassB : AbstractClass
        {
            public override void PrimitiveOperation1()
            {
                Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
            }
            public override void PrimitiveOperation2()
            {
                Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
            }
        }
    }
}
