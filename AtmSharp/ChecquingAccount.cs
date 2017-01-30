using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtmSharp
{
    /// <summary>
    /// Represents a checquing account that has an overdraft limit and a maximum interest rate.
    /// ChequingAccount IS-A(n) Account (inheritance). 
    /// </summary>
    class ChecquingAccount : Account 
    {
        /// <summary>
        /// The amount of overdraft is constant. Defined as such and accessible
        /// through the name of the class along with the DOT notation. The "const" keyword makes it impossible to change the value
        /// of the field variable
        /// </summary>
        private const double OVERDRAFT_LIMIT = 500.0;

        /// <summary>
        /// The maximum interest rate for checquing accounts. Defined as such and accessible
        /// through the name of the class along with the DOT notation. The "const" keyword makes it impossible to change the value
        /// of the field variable 
        /// </summary>
        private const float MAX_INTEREST_RATE = 1.0f;
    }
}
