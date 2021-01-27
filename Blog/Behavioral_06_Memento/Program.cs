using System;

namespace Behavioral_06_Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.Originator originator = new Default.Originator { State = "On" };
            // Default.Caretaker caretaker = new Default.Caretaker
            // {
            //     Memento = originator.CreateMemento()
            // };
            //
            // originator.State = "Off";
            //
            // originator.PreviousStep(caretaker.Memento);

            #endregion

            #region Situation

            Situation.ScanTheBarcode scanTheBarcode = new Situation.ScanTheBarcode();
            Situation.Caretaker caretaker = new Situation.Caretaker
            {
                Memento = scanTheBarcode.CreateMemento()
            };

            scanTheBarcode.AddProducts(caretaker.Memento, "麵包");
            scanTheBarcode.AddProducts(caretaker.Memento, "蘋果");
            scanTheBarcode.AddProducts(caretaker.Memento, "餅乾");
            scanTheBarcode.AddProducts(caretaker.Memento, "蛋糕切片");
            scanTheBarcode.PreviousStep(caretaker.Memento);
            scanTheBarcode.AddProducts(caretaker.Memento, "整塊蛋糕");

            #endregion

            Console.ReadLine();
        }
    }
}
