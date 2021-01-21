using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_01_ChainOfResponsibility
{
    public class Situation
    {
        /// <summary>
        /// 請假簽核抽象類別
        /// </summary>
        public abstract class Leave
        {
            protected Leave successor;

            public void SetSuccessor(Leave successor)
            {
                this.successor = successor;
            }

            public abstract void TakeALeave(int days);
        }

        /// <summary>
        /// 店長簽核實作
        /// </summary>
        public class StoreManagerApprove : Leave
        {
            public override void TakeALeave(int days)
            {
                if (days <= 3)
                {
                    Console.WriteLine($"Store Manager : OK~");
                }
                else if (successor != null)
                {
                    Console.WriteLine($"Store Manager : OK~");
                    successor.TakeALeave(days);
                }
            }
        }

        /// <summary>
        /// 區主管簽核實作
        /// </summary>
        public class DistrictManagerApprove : Leave
        {
            public override void TakeALeave(int days)
            {
                if (days <= 7)
                {
                    Console.WriteLine($"District Manager : OK~");
                }
                else if (successor != null)
                {
                    Console.WriteLine($"District Manager : OK~");
                    successor.TakeALeave(days);
                }
            }
        }

        /// <summary>
        /// 總經理簽核實作
        /// </summary>
        public class GeneralManagerApprove : Leave
        {
            public override void TakeALeave(int days)
            {
                if (days > 7)
                {
                    Console.WriteLine($"General Manager : OK~");
                }
            }
        }
    }
}
