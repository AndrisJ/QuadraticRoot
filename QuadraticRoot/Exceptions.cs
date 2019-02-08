using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticRoot
{
    public class ACannotBeZeroException : Exception
    {
        public ACannotBeZeroException()
        {}
        public override string Message
        {
            get
            {
                return "A == 0 the equation is not quadratic. Division by Zero not possible.";
            }

        }
    }
    public class DiscriminantCannotBeNegativeException : Exception
    {
        public DiscriminantCannotBeNegativeException()
        { }
        public override string Message
        {
            get
            {
                return "Cannot execute square root from negative discriminant.";
            }

        }
    }
}
