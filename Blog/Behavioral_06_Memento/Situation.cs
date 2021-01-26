using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_06_Memento
{
    public class Situation
    {
        /// <summary>
        /// 結帳刷條碼
        /// </summary>
        public class ScanTheBarcode
        {
            private string _products;

            public void AddProducts(Memento memento, string product)
            {
                if (string.IsNullOrWhiteSpace(_products))
                {
                    _products = product;
                }
                else
                {
                    _products += ", " + product;
                }

                memento.SetState(_products);

                Console.WriteLine($"Products = {_products}");
            }

            public Memento CreateMemento()
            {
                return (new Memento());
            }

            public void PreviousStep(Memento memento)
            {
                Console.WriteLine("\n== 上一步 ==");
                memento.State.Pop();
                _products = memento.State.Pop();
                Console.WriteLine($"Products = {_products}");
            }
        }

        /// <summary>
        /// 負責保存 ScanTheBarcode 的狀態
        /// </summary>
        public class Memento
        {
            public Stack<string> State { get; }

            public Memento()
            {
                State = new Stack<string>();
            }

            public void SetState(string state)
            {
                State.Push(state);
            }
        }

        /// <summary>
        /// 存放 Memento 但不操作
        /// </summary>
        public class Caretaker
        {
            public Memento Memento { set; get; }
        }
    }
}
