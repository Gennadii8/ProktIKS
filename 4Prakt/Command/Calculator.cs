using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }
        
        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }

        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }

        public double Sub(double operand)
        {
            return Run(new Sub(arithmeticUnit, operand));
        }

        public double Mult(double operand)
        {
            return Run(new Mult(arithmeticUnit, operand));
        }

        public double Divide(double operand)
        {
            return Run(new Divide(arithmeticUnit, operand));
        }

        public double Undo(int steps)
        {
            controlUnit.Undo(steps);
            return arithmeticUnit.Register;
        }

        public double Redo(int steps)
        {
            controlUnit.Redo(steps);
            return arithmeticUnit.Register;
        }


    }
}
