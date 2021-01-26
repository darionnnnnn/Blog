using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_06_Memento
{
    public class Default
    {
        /// <summary>
        /// 內部狀態需要保存的物件
        /// </summary>
        public class Originator
        {
            private string _state;

            public string State
            {
                get => _state;
                set
                {
                    _state = value;
                    Console.WriteLine($"State = {_state}");
                }
            }

            public Memento CreateMemento()
            {
                return (new Memento(_state));
            }

            public void SetMemento(Memento memento)
            {
                Console.WriteLine("Restoring state...");
                State = memento.State;
            }
        }

        /// <summary>
        /// 負責保存 Originator 的狀態
        /// </summary>
        public class Memento
        {
            public string State { get; }

            public Memento(string state)
            {
                State = state;
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
