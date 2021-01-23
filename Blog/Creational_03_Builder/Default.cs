using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_03_Builder
{
    public class Default
    {
        /// <summary>
        /// 定義建造的流程細節
        /// </summary>
        public class Director
        {
            public void Construct(IBuilder builder)
            {
                builder.BuildPartA();
                builder.BuildPartB();
            }
        }

        /// <summary>
        /// 建造者方法的介面
        /// </summary>
        public interface IBuilder
        {
            void BuildPartA();
            void BuildPartB();
            Product GetResult();
        }

        /// <summary>
        /// 建造者方法的實作 1
        /// </summary>
        public class ConcreteBuilder1 : IBuilder
        {
            private Product _product = new Product();

            public void BuildPartA()
            {
                _product.Add("PartA1");
            }

            public void BuildPartB()
            {
                _product.Add("PartB1");
            }

            public Product GetResult()
            {
                return _product;
            }
        }

        /// <summary>
        /// 建造者方法的實作 2
        /// </summary>
        public class ConcreteBuilder2 : IBuilder
        {
            private Product _product = new Product();

            public void BuildPartA()
            {
                _product.Add("PartA2");
            }

            public void BuildPartB()
            {
                _product.Add("PartB2");
            }

            public Product GetResult()
            {
                return _product;
            }
        }

        /// <summary>
        /// 正在構造的複雜對象
        /// </summary>
        public class Product
        {
            private List<string> _parts = new List<string>();

            public void Add(string part)
            {
                _parts.Add(part);
            }

            public void Show()
            {
                Console.WriteLine("\nProduct Parts -------");

                foreach (string part in _parts)
                {
                    Console.WriteLine(part);
                }
            }
        }
    }
}
