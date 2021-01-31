using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_11_Visitor
{
    public class Situation
    {
        /// <summary>
        /// 訪問者的介面
        /// </summary>
        public interface IVisitor
        {
            void OpenMessage(Open open);
            void CloseMessage(Close close);
        }

        /// <summary>
        /// 訪問者實作，折扣資訊
        /// </summary>
        public class DiscountMessage : IVisitor
        {
            public void OpenMessage(Open open)
            {
                Console.WriteLine($"營業中：今日咖啡第二杯半價");
            }

            public void CloseMessage(Close close)
            {
                Console.WriteLine($"非營業時間：X 月 X 日 咖啡買一送一");
            }
        }

        /// <summary>
        /// 訪問者實作，會員資訊
        /// </summary>
        public class MemberMessage : IVisitor
        {
            public void OpenMessage(Open open)
            {
                Console.WriteLine($"營業中：今日會員集點兩倍送");
            }

            public void CloseMessage(Close close)
            {
                Console.WriteLine($"非營業時間：會員申辦只要 200 元");
            }
        }

        /// <summary>
        /// 元素的介面
        /// </summary>
        public interface IElement
        {
            void Accept(IVisitor visitor);
        }

        /// <summary>
        /// 元素實作，營業中
        /// </summary>
        public class Open : IElement
        {
            public void Accept(IVisitor visitor)
            {
                visitor.OpenMessage(this);
            }
        }

        /// <summary>
        /// 元素實作，非營業時間
        /// </summary>
        public class Close : IElement
        {
            public void Accept(IVisitor visitor)
            {
                visitor.CloseMessage(this);
            }
        }

        /// <summary>
        /// 定義元素(是否營業)與欲顯示看板資訊
        /// </summary>
        public class ObjectStructure
        {
            private List<IElement> _elements = new List<IElement>();

            public void Attach(IElement element)
            {
                _elements.Add(element);
            }

            public void Detach(IElement element)
            {
                _elements.Remove(element);
            }

            public void Accept(IVisitor visitor)
            {
                foreach (IElement element in _elements)
                {
                    element.Accept(visitor);
                }
            }
        }
    }
}
