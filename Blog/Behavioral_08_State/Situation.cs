using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_08_State
{
    public class Situation
    {
        /// <summary>
        /// 狀態的介面
        /// </summary>
        public interface IState
        {
            void Handle(BreadStore breadStore, int time);
        }


        /// <summary>
        /// 還沒營業喔
        /// </summary>
        public class Close : IState
        {
            public void Handle(BreadStore breadStore, int time)
            {
                if (time < 10 || time > 21)
                {
                    Console.WriteLine($"現在時間：{time} 點, 還沒營業喔~");
                }
                else
                {
                    breadStore.State = new FreshBread();
                    breadStore.Request(time);
                }
            }
        }

        /// <summary>
        /// 麵包出爐囉
        /// </summary>
        public class FreshBread : IState
        {
            public void Handle(BreadStore breadStore, int time)
            {
                if (time >= 10 && time < 14)
                {
                    Console.WriteLine($"現在時間：{time} 點, 麵包出爐囉~");
                }
                else
                {
                    breadStore.State = new BreadAndCoffee();
                    breadStore.Request(time);
                }
            }
        }

        /// <summary>
        /// 麵包搭配咖啡打八折
        /// </summary>
        public class BreadAndCoffee : IState
        {
            public void Handle(BreadStore breadStore, int time)
            {
                if (time >= 14 && time < 20)
                {
                    Console.WriteLine($"現在時間：{time} 點, 麵包搭配咖啡打八折喔~");
                }
                else
                {
                    breadStore.State = new ClearingSale();
                    breadStore.Request(time);
                }
            }
        }

        /// <summary>
        /// 麵包全面七折喔
        /// </summary>
        public class ClearingSale : IState
        {
            public void Handle(BreadStore breadStore, int time)
            {
                if (time >= 20)
                {
                    Console.WriteLine($"現在時間：{time} 點, 麵包全面七折喔~");
                }
                else
                {
                    breadStore.State = new Close();
                    breadStore.Request(time);
                }
            }
        }

        /// <summary>
        /// 需要判斷狀態來運作的物件
        /// </summary>
        public class BreadStore
        {
            public IState State { get; set; }

            public BreadStore(IState state)
            {
                State = state;
            }

            public void Request(int time)
            {
                State.Handle(this, time);
            }
        }
    }
}
