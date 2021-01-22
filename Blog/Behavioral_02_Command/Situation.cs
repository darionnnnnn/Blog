using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_02_Command
{
    public class Situation
    {
        /// <summary>
        /// 點餐介面
        /// </summary>
        public interface IOrder
        {
            public void Execute();
        }

        /// <summary>
        /// 點咖啡實作
        /// </summary>
        public class OrderCoffee : IOrder
        {
            public Employee Employee { get; }
            public OrderCoffee(Employee employee)
            {
                Employee = employee;
            }

            public void Execute()
            {
                Employee.Coffee();
            }
        }

        /// <summary>
        /// 點餐盒實作
        /// </summary>
        public class OrderBoxedMeal : IOrder
        {
            public Employee Employee { get; }
            public OrderBoxedMeal(Employee employee)
            {
                Employee = employee;
            }

            public void Execute()
            {
                Employee.BoxedMeal();
            }
        }

        /// <summary>
        /// 員工，包含熟食部 & 飲料部
        /// </summary>
        public class Employee
        {
            // 咖啡
            public void Coffee()
            {
                Console.WriteLine("飲料部收到 咖啡 訂單");
            }

            // 餐盒
            public void BoxedMeal()
            {
                Console.WriteLine("熟食部收到 餐盒 訂單");
            }
        }

        /// <summary>
        /// 儲存與調用命令
        /// </summary>
        public class Invoker
        {
            private IOrder _Order { get; set; }

            public void SetOrder(IOrder order)
            {
                _Order = order;
            }

            public void RemoveOrder()
            {
                _Order = null;
            }

            public void ExecuteCommand()
            {
                if (_Order is null)
                {
                    Console.WriteLine($"Please order first.");
                }
                else
                {
                    _Order.Execute();
                }
            }
        }
    }
}
