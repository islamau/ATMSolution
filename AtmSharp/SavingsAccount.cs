using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtmSharp
{
    /// <summary>
    /// Represents a savings account. A saving account has specific business logic. It has
    /// a minimum interest rate and an additional deposit business rule.
    /// SavingsAccount IS-A(n) account
    /// </summary>
    class SavingsAccount : Account
    {
        /// <summary>
        /// The matching deposit ratio. For every dollar deposit this account will
        /// automatically be credited with 0.5 dollars. Defined as a constant and accessible
        /// through the name of the class along with the DOT notation
        /// </summary>
        private const double MATCHING_DEPOSIT_RATIO = 0.5;

        /// <summary>
        /// The minimum interest rate for savings accounts. Defined as a constant and accessible
        /// through the name of the class along with the DOT notation 
        /// </summary>
        private const float MIN_INTEREST_RATE = 3.0f;
    }
}
