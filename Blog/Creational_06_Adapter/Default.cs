using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_01_Adapter
{
    public class Default
    {
        /// <summary>
        /// 定義呼叫端使用的接口
        /// </summary>
        public interface ITarget
        {
            void Request();
        }

        /// <summary>
        /// 實作 Adapter
        /// </summary>
        public class Adapter : ITarget
        {
            private Adaptee _adaptee = new Adaptee();

            public void Request()
            {
                _adaptee.SpecificRequest();
            }
        }

        /// <summary>
        /// 實作端的接口
        /// </summary>
        public class Adaptee
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest()");
            }
        }
    }
}
