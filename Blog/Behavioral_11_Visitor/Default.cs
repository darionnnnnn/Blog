using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_11_Visitor
{
    public class Default
    {
        /// <summary>
        /// 定義元素與欲執行的操作邏輯(Visitor)
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

        /// <summary>
        /// 訪問者的介面
        /// </summary>
        public interface IVisitor
        {
            void VisitConcreteElementA(ConcreteElementA concreteElementA);
            void VisitConcreteElementB(ConcreteElementB concreteElementB);
        }

        /// <summary>
        /// 訪問者實作，定義元素的操作邏輯
        /// </summary>
        public class ConcreteVisitor1 : IVisitor
        {
            public void VisitConcreteElementA(ConcreteElementA concreteElementA)
            {
                Console.WriteLine($"{concreteElementA.GetType().Name} visited by {this.GetType().Name}");
            }

            public void VisitConcreteElementB(ConcreteElementB concreteElementB)
            {
                Console.WriteLine($"{concreteElementB.GetType().Name} visited by {this.GetType().Name}");
            }
        }

        /// <summary>
        /// 訪問者實作，定義元素的操作邏輯
        /// </summary>
        public class ConcreteVisitor2 : IVisitor
        {
            public void VisitConcreteElementA(ConcreteElementA concreteElementA)
            {
                Console.WriteLine($"{concreteElementA.GetType().Name} visited by {this.GetType().Name}");
            }

            public void VisitConcreteElementB(ConcreteElementB concreteElementB)
            {
                Console.WriteLine($"{concreteElementB.GetType().Name} visited by {this.GetType().Name}");
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
        /// 元素實作，經由 ObjectStructure 指定操作邏輯(Visitor)
        /// </summary>
        public class ConcreteElementA : IElement
        {
            public void Accept(IVisitor visitor)
            {
                visitor.VisitConcreteElementA(this);
            }

            public void OperationA()
            {
            }
        }

        /// <summary>
        /// 元素實作，經由 ObjectStructure 指定操作邏輯(Visitor)
        /// </summary>
        public class ConcreteElementB : IElement
        {
            public void Accept(IVisitor visitor)
            {
                visitor.VisitConcreteElementB(this);
            }

            public void OperationB()
            {
            }
        }
    }
}
