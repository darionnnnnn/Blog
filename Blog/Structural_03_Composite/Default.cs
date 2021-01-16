using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_03_Composite
{
    public class Default
    {
        /// <summary>
        /// 定義容器 interface
        /// </summary>
        public interface IComponent
        {
            string Name { get; }

            void Add(IComponent c);
            void Remove(IComponent c);
            void Display(int depth);
        }

        /// <summary>
        /// 容器實作
        /// </summary>
        public class Composite : IComponent
        {
            private readonly List<IComponent> _children = new List<IComponent>();
            public string Name { get; }

            public Composite(string name)
            {
                Name = name;
            }

            public void Add(IComponent component)
            {
                _children.Add(component);
            }

            public void Remove(IComponent component)
            {
                _children.Remove(component);
            }

            public void Display(int depth)
            {
                var itemName = depth > 0 ? new string('+', depth) + " " + Name : Name;
                Console.WriteLine(itemName);

                foreach (IComponent component in _children)
                {
                    component.Display(depth + 3);
                }
            }
        }

        /// <summary>
        /// 實體對象實作
        /// </summary>
        public class Leaf : IComponent
        {
            public string Name { get; }

            public Leaf(string name)
            {
                Name = name;
            }

            public void Add(IComponent component)
            {
                Console.WriteLine("Cannot add child to leaf");
            }

            public void Remove(IComponent component)
            {
                Console.WriteLine("Cannot remove child from leaf");
            }

            public void Display(int depth)
            {
                Console.WriteLine(new string('-', depth) + " " + Name);
            }
        }
    }
}