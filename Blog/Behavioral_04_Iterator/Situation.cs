using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_04_Iterator
{
    public class Situation
    {
        /// <summary>
        /// 員工類型分為 一般員工 & 榮譽員工
        /// </summary>
        public enum EmployeeType
        {
            General,
            Honours
        }

        /// <summary>
        /// 員工資料
        /// </summary>
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public EmployeeType EmployeeType { get; set; }
        }

        /// <summary>
        /// 包含迭代器的員工的介面
        /// </summary>
        public interface IEmployee
        {
            IIterator CreateIterator();
        }

        /// <summary>
        /// 包含迭代器的員工實作
        /// </summary>
        public class Employees : IEmployee
        {
            // 此處並非範例重點，故直接指定容量為 10
            private Employee[] _items = new Employee[10];

            public IIterator CreateIterator()
            {
                return new ConcreteIterator(this);
            }

            public int ElementCount => _items.Length;

            // Indexer
            public Employee this[int index]
            {
                get => _items[index];
                set =>_items.SetValue(value, index);
            }
        }

        /// <summary>
        /// 迭代器介面
        /// </summary>
        public interface IIterator
        {
            Employee First();
            Employee Next();
            bool IsDone();
            Employee CurrentItem();
        }

        /// <summary>
        /// 迭代器實作
        /// </summary>
        public class ConcreteIterator : IIterator
        {
            private Employees _aggregate { get; }
            private int _current = 0;

            public ConcreteIterator(Employees aggregate)
            {
                _aggregate = aggregate;
            }

            // 取得第一個元素
            public Employee First()
            {
                var employee = _aggregate[0];

                if (employee != null && employee.EmployeeType == EmployeeType.Honours)
                {
                    Next();
                }

                return employee;
            }

            // 取得接續元素
            public Employee Next()
            {
                Employee employee = null;
                if (_current < _aggregate.ElementCount - 1)
                {
                    employee = _aggregate[++_current];
                }

                if (employee != null && employee.EmployeeType == EmployeeType.Honours)
                {
                    return Next();
                }

                return employee;
            }

            // 取得當前元素
            public Employee CurrentItem()
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
