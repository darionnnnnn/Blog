using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_05_Mediator
{
    public class Situation
    {
        /// <summary>
        /// 中介者的介面
        /// </summary>
        public interface IMediator
        {
            void GetOtherStoreInStore(IStore store);
        }

        /// <summary>
        /// 中介者實作
        /// </summary>
        public class Mediator : IMediator
        {
            public IStore StoreDaan { get; set; }
            public IStore StoreXinyi { get; set; }

            public void GetOtherStoreInStore(IStore store)
            {
                if (store == StoreDaan)
                {
                    StoreXinyi.GetInStore();
                }
                else
                {
                    StoreDaan.GetInStore();
                }
            }
        }

        /// <summary>
        /// 包含 Mediator 的門市介面
        /// </summary>
        public interface IStore
        {
            void GetInStore();
        }

        /// <summary>
        /// 大安店實作，透過 Mediator 取得信義店庫存
        /// </summary>
        public class StoreDaan : IStore
        {
            private IMediator _mediator { get; }
            public StoreDaan(IMediator mediator)
            {
                _mediator = mediator;
            }

            public void GetOtherStoreInStore()
            {
                _mediator.GetOtherStoreInStore(this);
            }

            public void GetInStore()
            {
                Console.WriteLine($"大安店 目前庫存 咖啡 100 杯，蛋糕 5 片");
            }
        }

        /// <summary>
        /// 信義店實作，透過 Mediator 取得大安店庫存
        /// </summary>
        public class StoreXinyi : IStore
        {
            private IMediator _mediator { get; }
            public StoreXinyi(IMediator mediator)
            {
                _mediator = mediator;
            }

            public void GetOtherStoreInStore()
            {
                _mediator.GetOtherStoreInStore(this);
            }

            public void GetInStore()
            {
                Console.WriteLine($"信義店 目前庫存 咖啡 10 杯，蛋糕 120 片");
            }
        }
    }
}
