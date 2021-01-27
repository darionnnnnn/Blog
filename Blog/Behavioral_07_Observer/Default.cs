using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_07_Observer
{
    public class Default
    {
        /// <summary>
        /// 主題的抽象類別，實作加入 & 移除觀察者
        /// </summary>
        public abstract class Subject
        {
            private List<IObserver> _observers = new List<IObserver>();

            public void Attach(IObserver observer)
            {
                _observers.Add(observer);
            }

            public void Detach(IObserver observer)
            {
                _observers.Remove(observer);
            }

            public void Notify()
            {
                foreach (IObserver observer in _observers)
                {
                    observer.Update();
                }
            }
        }

        /// <summary>
        /// 主題實作
        /// </summary>
        public class ConcreteSubject : Subject
        {
            public string SubjectState { get; set; }
        }

        /// <summary>
        /// 觀察者介面
        /// </summary>
        public interface IObserver
        {
            void Update();
        }

        /// <summary>
        /// 觀察者實作
        /// </summary>
        public class ConcreteObserver : IObserver
        {
            public ConcreteSubject Subject { get; set; }
            private string _name;
            private string _observerState;

            public ConcreteObserver(ConcreteSubject subject, string name)
            {
                Subject = subject;
                _name = name;
            }

            public void Update()
            {
                _observerState = Subject.SubjectState;
                Console.WriteLine($"Observer {_name}'s new state is {_observerState}");
            }
        }
    }
}
