using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_05_Facade
{
    public class Default
    {
        /// <summary>
        /// 子系統 A
        /// </summary>
        public class SubSystemA
        {
            public void Method()
            {
                Console.WriteLine("SubSystemA Method");
            }
        }

        /// <summary>
        /// 子系統 B
        /// </summary>
        public class SubSystemB
        {
            public void Method()
            {
                Console.WriteLine("SubSystemB Method");
            }
        }

        /// <summary>
        /// 子系統 C
        /// </summary>
        public class SubSystemC
        {
            public void Method()
            {
                Console.WriteLine("SubSystemC Method");
            }
        }

        /// <summary>
        /// 子系統 D
        /// </summary>
        public class SubSystemD
        {
            public void Method()
            {
                Console.WriteLine("SubSystemD Method");
            }
        }

        /// <summary>
        /// Facade 整合子系統並提供外部呼叫
        /// </summary>
        public class Facade
        {
            private SubSystemA _subSystemA;
            private SubSystemB _subSystemB;
            private SubSystemC _subSystemC;
            private SubSystemD _subSystemD;

            public Facade()
            {
                _subSystemA = new SubSystemA();
                _subSystemB = new SubSystemB();
                _subSystemC = new SubSystemC();
                _subSystemD = new SubSystemD();
            }

            public void MethodA()
            {
                Console.WriteLine("\nMethodA() ---- ");
                _subSystemA.Method();
                _subSystemB.Method();
                _subSystemC.Method();
            }

            public void MethodB()
            {
                Console.WriteLine("\nMethodB() ---- ");
                _subSystemB.Method();
                _subSystemD.Method();
            }
        }
    }
}
