using System;
using System.Collections;
using System.Collections.Generic;

namespace CommandPattern.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly IList<ICommand> _commands;

        public MacroCommand(IList<ICommand> commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}