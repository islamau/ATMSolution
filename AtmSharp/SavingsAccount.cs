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

        /// <summary>
        /// Provide a constructor and ensure the base constructor gets called
        /// NOTE: the constructor assigns default values to each parameter allowing the code
        /// not to supply them (i.e. acct = SavingsAccount()). If the calling code does not supply
        /// values for the two parameters they will receive these default values. This is used
        /// when the accounts are created from data files 
        /// </summary>
        /// <param name="acctNo">the account number that uniquely identified the account</param>
        /// <param name="clientName">the name of the account holder</param>   
        public SavingsAccount(int acctNo = 0, string acctHolderName = "") :
            base(acctNo, acctHolderName)
        {
            //As the checquing account doesn't have any specific field variables there is nothing
            //to initialize. However the constructor is required in order to pass data provided
            //by client code to the base class through the base(..) call
        }

    }
}
