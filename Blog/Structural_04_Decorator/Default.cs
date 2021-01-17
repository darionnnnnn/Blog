using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_04_Decorator
{
    public class Default
    {
        /// <summary>
        /// 被裝飾物件的抽象類別
        /// </summary>
        public abstract class Component
        {
            public abstract void Operation();
        }

        /// <summary>
        /// 實作被裝飾物件
        /// </summary>
        public class ConcreteComponent : Component
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteComponent.Operation()");
            }
        }

        /// <summary>
        /// 裝飾者抽象類別，繼承被裝飾者抽象類別
        /// </summary>
        public abstract class Decorator : Component
        {
            protected Component component;

            public void SetComponent(Component component)
            {
                this.component = component;
            }

            public override void Operation()
            {
                if (component != null)
                {
                    component.Operation();
                }
            }
        }

        /// <summary>
        /// 實作裝飾者 A
        /// </summary>
        public class ConcreteDecoratorA : Decorator
        {
            public override void Operation()
            {
                base.Operation();
                Console.WriteLine("ConcreteDecoratorA.Operation()");
            }
        }

        /// <summary>
        /// 實作裝飾者 B
        /// </summary>
        public class ConcreteDecoratorB : Decorator
        {
            public override void Operation()
            {
                base.Operation();
                AddedBehavior();
                Console.WriteLine("ConcreteDecoratorB.Operation()");
            }

            void AddedBehavior()
            {
                // Do something...
            }
        }
    }
}