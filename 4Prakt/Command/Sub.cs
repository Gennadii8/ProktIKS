using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Sub: Command
    {
        public Sub(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            unit.Run('-', operand);
        }

        public override void UnExecute()
        {
            unit.Run('+', operand);
        }
    }
}
