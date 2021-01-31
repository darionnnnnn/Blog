using System;

namespace Behavioral_11_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // Default.ObjectStructure objectStructure = new Default.ObjectStructure();
            //
            // objectStructure.Attach(new Default.ConcreteElementA());
            // objectStructure.Attach(new Default.ConcreteElementB());
            //
            // objectStructure.Accept(new Default.ConcreteVisitor1());
            // objectStructure.Accept(new Default.ConcreteVisitor2());

            #endregion

            #region Situation

            Situation.ObjectStructure objectStructure = new Situation.ObjectStructure();

            objectStructure.Attach(new Situation.Open());
            objectStructure.Attach(new Situation.Close());

            Console.WriteLine($"折扣資訊");
            objectStructure.Accept(new Situation.DiscountMessage());
            Console.WriteLine($"\n會員資訊");
            objectStructure.Accept(new Situation.MemberMessage());

            #endregion

            Console.ReadLine();
        }
    }
}
