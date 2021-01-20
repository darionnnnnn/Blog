using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Structural_07_Proxy
{
    public class Situation
    {
        /// <summary>
        /// 角色
        /// </summary>
        public enum Position
        {
            StoreManager,
            Clerk
        }

        /// <summary>
        /// 銷售報表介面
        /// </summary>
        public interface IRevenueReport
        {
            void GetReport();
        }

        /// <summary>
        /// 銷售報表實作
        /// </summary>
        public class RevenueReport : IRevenueReport
        {
            public void GetReport()
            {
                Console.WriteLine("Return revenue report.");
            }
        }

        /// <summary>
        /// 代理，繼承銷售報表介面
        /// </summary>
        public class Proxy : IRevenueReport
        {
            private RevenueReport _revenueReport { get; set; }
            private Position _position { get; }

            public Proxy(Position position)
            {
                _position = position;
                Console.WriteLine($"Position：{_position.ToString()}");
            }

            public void GetReport()
            {
                if (_position != Position.StoreManager)
                {
                    Console.WriteLine($"{_position.ToString()} can't get revenue report.");
                    return;
                }

                // Use 'lazy initialization'
                if (_revenueReport == null)
                {
                    _revenueReport = new RevenueReport();
                }

                _revenueReport.GetReport();
            }
        }
    }
}
