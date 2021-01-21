using System;
using System.Collections.Generic;

namespace Behavioral_01_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.Handler handler1 = new Default.ConcreteHandler1();
            // Default.Handler handler2 = new Default.ConcreteHandler2();
            // Default.Handler handler3 = new Default.ConcreteHandler3();
            // handler1.SetSuccessor(handler2);
            // handler2.SetSuccessor(handler3);
            //
            // var requests = new[]{ 5, 12, 24 };
            //
            // Console.WriteLine("Array elements: 5, 12, 24");
            //
            // foreach (var request in requests)
            // {
            //     handler1.HandleRequest(request);
            // }

            #endregion

            #region Situation

            Situation.StoreManagerApprove storeManager = new Situation.StoreManagerApprove();
            Situation.DistrictManagerApprove districtManager = new Situation.DistrictManagerApprove();
            Situation.GeneralManagerApprove generalManager = new Situation.GeneralManagerApprove();
            storeManager.SetSuccessor(districtManager);
            districtManager.SetSuccessor(generalManager);
            
            Console.WriteLine($"請假 1 天");
            storeManager.TakeALeave(1);
            Console.WriteLine($"\n");
            
            Console.WriteLine($"請假 5 天");
            storeManager.TakeALeave(5);
            Console.WriteLine($"\n");
            
            Console.WriteLine($"請假 10 天");
            storeManager.TakeALeave(10);
            Console.WriteLine($"\n");

            #endregion

            Console.ReadLine();
        }
    }
}
