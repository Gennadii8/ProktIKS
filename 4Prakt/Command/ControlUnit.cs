﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ControlUnit
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;

        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }

        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }

        public void Undo(int steps)
        {
            commands[current - 1].UnExecute();
        }

        public void Redo(int steps)
        {
            commands[current - 1].Execute();
        }
    }
}
