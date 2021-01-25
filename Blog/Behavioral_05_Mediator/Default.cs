using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_05_Mediator
{
    public class Default
    {
        /// <summary>
        /// 中介者的介面
        /// </summary>
        public interface IMediator
        {
            void Send(string message, IColleague colleague);
        }

        /// <summary>
        /// 中介者實作
        /// </summary>
        public class ConcreteMediator : IMediator
        {
            public IColleague Colleague1 { get; set; }
            public IColleague Colleague2 { get; set; }

            public void Send(string message, IColleague colleague)
            {
                if (colleague == Colleague1)
                {
                    Colleague2.Notify(message);
                }
                else
                {
                    Colleague1.Notify(message);
                }
            }
        }

        /// <summary>
        /// 包含 Mediator 的介面
        /// </summary>
        public interface IColleague
        {
            void Send(string message);
            void Notify(string message);
        }

        /// <summary>
        /// Colleague 實作，可經由中介者與其他 ConcreteColleague 互動
        /// </summary>
        public class ConcreteColleague1 : IColleague
        {
            private IMediator _mediator { get; }
            public ConcreteColleague1(IMediator mediator)
            {
                _mediator = mediator;
            }

            public void Send(string message)
            {
                _mediator.Send(message, this);
            }

            public void Notify(string message)
            {
                Console.WriteLine($"Colleague1 gets message: {message}");
            }
        }

        /// <summary>
        /// Colleague 實作，可經由中介者與其他 ConcreteColleague 互動
        /// </summary>
        public class ConcreteColleague2 : IColleague
        {
            private IMediator _mediator { get; }
            public ConcreteColleague2(IMediator mediator)
            {
                _mediator = mediator;
            }

            public void Send(string message)
            {
                _mediator.Send(message, this);
            }

            public void Notify(string message)
            {
                Console.WriteLine($"Colleague2 gets message: {message}");
            }
        }
    }
}
