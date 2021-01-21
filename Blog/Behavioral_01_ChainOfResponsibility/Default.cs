using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_01_ChainOfResponsibility
{
    public class Default
    {
        /// <summary>
        /// 處理請求的抽象類別
        /// </summary>
        public abstract class Handler
        {
            protected Handler successor;

            public void SetSuccessor(Handler successor)
            {
                this.successor = successor;
            }

            public abstract void HandleRequest(int request);
        }

        /// <summary>
        /// 處理請求實作
        /// </summary>
        public class ConcreteHandler1 : Handler
        {
            public override void HandleRequest(int request)
            {
                if (request >= 0 && request < 10)
                {
                    Console.WriteLine($"{GetType().Name} handled request {request}");
                }
                else if (successor != null)
                {
                    successor.HandleRequest(request);
                }
            }
        }

        /// <summary>
        /// 處理請求實作
        /// </summary>
        public class ConcreteHandler2 : Handler
        {
            public override void HandleRequest(int request)
            {
                if (request >= 10 && request < 20)
                {
                    Console.WriteLine($"{GetType().Name} handled request {request}");
                }
                else if (successor != null)
                {
                    successor.HandleRequest(request);
                }
            }
        }

        /// <summary>
        /// 處理請求實作
        /// </summary>
        public class ConcreteHandler3 : Handler
        {
            public override void HandleRequest(int request)
            {
                if (request >= 20 && request < 30)
                {
                    Console.WriteLine($"{GetType().Name} handled request {request}");
                }
                else if (successor != null)
                {
                    successor.HandleRequest(request);
                }
            }
        }

    }
}
