using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_08_State
{
    public class Default
    {
        /// <summary>
        /// 狀態的介面
        /// </summary>
        public interface IState
        {
            void Handle(Context context);
        }

        /// <summary>
        /// 狀態實做
        /// </summary>
        public class ConcreteStateA : IState
        {
            public void Handle(Context context)
            {
                context.State = new ConcreteStateB();
            }
        }

        /// <summary>
        /// 狀態實做
        /// </summary>
        public class ConcreteStateB : IState
        {
            public void Handle(Context context)
            {
                context.State = new ConcreteStateA();
            }
        }

        /// <summary>
        /// 需要判斷狀態來運作的物件
        /// </summary>
        public class Context
        {
            private IState _state;

            public Context(IState state)
            {
                State = state;
            }

            public IState State
            {
                get => _state;
                set
                {
                    _state = value;
                    Console.WriteLine($"State: {_state.GetType().Name}");
                }
            }

            public void Request()
            {
                _state.Handle(this);
            }
        }
    }
}
