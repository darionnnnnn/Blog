using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_02_Command
{
    public class Default
    {
        /// <summary>
        /// 命令的父類別或介面
        /// </summary>
        public interface ICommand
        {
            public void Execute();
        }

        /// <summary>
        /// 命令實作
        /// </summary>
        public class ConcreteCommand : ICommand
        {
            public Receiver _receiver { get; }
            public ConcreteCommand(Receiver receiver)
            {
                _receiver = receiver;
            }

            public void Execute()
            {
                _receiver.Action();
            }
        }

        /// <summary>
        /// 被呼叫端
        /// </summary>
        public class Receiver
        {
            public void Action()
            {
                Console.WriteLine("Called Receiver.Action()");
            }
        }

        /// <summary>
        /// 儲存與調用命令
        /// </summary>
        public class Invoker
        {
            private ICommand _command { get; set; }

            public void SetCommand(ICommand command)
            {
                _command = command;
            }

            public void RemoveCommand()
            {
                _command = null;
            }

            public void ExecuteCommand()
            {
                if (_command is null)
                {
                    Console.WriteLine($"Please set command first.");
                }
                else
                {
                    _command.Execute();
                }
            }
        }
    }
}
