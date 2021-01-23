using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_03_Interpreter
{
    public class Default
    {
        /// <summary>
        /// 由直譯器來處理的內容
        /// </summary>
        public class Context
        {
        }

        /// <summary>
        /// 直譯的抽象類別或介面
        /// </summary>
        public abstract class AbstractExpression
        {
            public abstract void Interpret(Context context);
        }

        /// <summary>
        /// 直譯邏輯實作，已無接續項目，不再遞迴
        /// </summary>
        public class TerminalExpression : AbstractExpression
        {
            public override void Interpret(Context context)
            {
                Console.WriteLine("Called Terminal.Interpret()");
            }
        }

        /// <summary>
        /// 直譯邏輯實作，有接續項目
        /// </summary>
        public class NonterminalExpression : AbstractExpression
        {
            public override void Interpret(Context context)
            {
                Console.WriteLine("Called Nonterminal.Interpret()");
            }
        }
    }
}
