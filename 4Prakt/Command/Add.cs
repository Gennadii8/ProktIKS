using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Add : Command
    {
        public Add(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            unit.Run('+', operand);
        }

        public override void UnExecute()
        {
            unit.Run('-', operand);
        }
    }
}
