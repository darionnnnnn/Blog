using System;

namespace Behavioral_08_State
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.Context context = new Default.Context(new Default.ConcreteStateA());
            //
            // context.Request();
            // context.Request();
            // context.Request();
            // context.Request();

            #endregion

            #region Situation

            Situation.BreadStore breadStore = new Situation.BreadStore(new Situation.Close());

            breadStore.Request(9);
            breadStore.Request(10);
            breadStore.Request(13);
            breadStore.Request(14);
            breadStore.Request(20);

            #endregion

            Console.ReadLine();
        }
    }
}
