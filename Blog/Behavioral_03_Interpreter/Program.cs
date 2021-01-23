using System;
using System.Collections;

namespace Behavioral_03_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Default.Context context = new Default.Context();

            ArrayList list = new ArrayList();

            list.Add(new Default.TerminalExpression());
            list.Add(new Default.NonterminalExpression());
            list.Add(new Default.TerminalExpression());
            list.Add(new Default.TerminalExpression());

            foreach (Default.AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            Console.ReadLine();
        }
    }
}
