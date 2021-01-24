using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_04_Iterator
{
    public class Default
    {
        /// <summary>
        /// 包含迭代器的集合的介面
        /// </summary>
        public interface IAggregate
        {
            IIterator CreateIterator();
        }

        /// <summary>
        /// 包含迭代器的集合實作
        /// </summary>
        public class ConcreteAggregate : IAggregate
        {
            private ArrayList _items = new ArrayList();

            public IIterator CreateIterator()
            {
                return new ConcreteIterator(this);
            }

            public int ElementCount => _items.Count;

            // Indexer
            public object this[int index]
            {
                get => _items[index];
                set => _items.Insert(index, value);
            }
        }

        /// <summary>
        /// 迭代器介面
        /// </summary>
        public interface IIterator
        {
            object First();
            object Next();
            bool IsDone();
            object CurrentItem();
        }

        /// <summary>
        /// 迭代器實作
        /// </summary>
        public class ConcreteIterator : IIterator
        {
            private ConcreteAggregate _aggregate { get; }
            private int _current = 0;

            public ConcreteIterator(ConcreteAggregate aggregate)
            {
                _aggregate = aggregate;
            }

            // 取得第一個元素
            public object First()
            {
                return _aggregate[0];
            }

            // 取得接續元素
            public object Next()
            {
                object ret = null;
                if (_current < _aggregate.ElementCount - 1)
                {
                    ret = _aggregate[++_current];
                }

                return ret;
            }

            // 取得當前元素
            public object CurrentItem()
            {
                return _aggregate[_current];
            }

            // 是否為最後一個元素
            public bool IsDone()
            {
                return _current >= _aggregate.ElementCount;
            }
        }
    }
}
