using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_07_Proxy
{
    public class Default
    {
        /// <summary>
        /// 被代理之服務介面
        /// </summary>
        public interface ISubject
        {
            void Request();
        }

        /// <summary>
        /// 被代理之服務
        /// </summary>
        public class RealSubject : ISubject
        {
            public void Request()
            {
                Console.WriteLine("Called RealSubject.Request()");
            }
        }

        /// <summary>
        /// 代理，繼承被代理之服務介面
        /// </summary>
        public class Proxy : ISubject
        {
            private RealSubject _realSubject;

            public void Request()
            {
                // Use 'lazy initialization'
                if (_realSubject == null)
                {
                    _realSubject = new RealSubject();
                }

                Console.WriteLine("Called Proxy.Request()");

                _realSubject.Request();
            }
        }
    }
}