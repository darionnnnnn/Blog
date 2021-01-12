using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_04_Prototype
{
    public class Default
    {
        /// <summary>
        /// 原有邏輯的介面
        /// </summary>
        public interface IPrototype
        {
            string Id { get; }

            public IPrototype Clone();
        }

        /// <summary>
        /// 原有邏輯的實作
        /// </summary>
        public class ConcretePrototype : IPrototype
        {
            public string Id { get; }

            public ConcretePrototype(string id)
            {
                Id = id;
            }

            // Returns a shallow copy
            public IPrototype Clone()
            {
                return (IPrototype)this.MemberwiseClone();
            }
        }
    }
}
