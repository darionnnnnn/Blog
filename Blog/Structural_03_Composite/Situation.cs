using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_03_Composite
{
    public class Situation
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
        /// 地區實作
        /// </summary>
        public class District : IComponent
        {
            private readonly List<IComponent> _children = new List<IComponent>();
            public string Name { get; }

            public District(string name)
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
        /// 門市實作
        /// </summary>
        public class Store : IComponent
        {
            public string Name { get; }

            public Store(string name)
            {
                Name = name;
            }

            public void Add(IComponent component)
            {
                Console.WriteLine("門市無法新增子階層");
            }

            public void Remove(IComponent component)
            {
                Console.WriteLine("門市無法移除子階層");
            }

            public void Display(int depth)
            {
                Console.WriteLine(new string('-', depth) + " " + Name);
            }
        }
    }
}
