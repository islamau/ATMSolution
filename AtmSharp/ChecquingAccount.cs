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

        /// <summary>
        /// The constructor assigns default values to each parameter allowing the code
        /// not to supply them (i.e. acct = ChequingAccount()). If the calling code does not supply
        /// values for the two parameters they will receive these default values. This is used
        /// when the accounts are created from data files
        /// </summary>
        /// <param name="acctNo">the account number that uniquely identified the account</param>
        /// <param name="acctHolderName">the name of the account holder</param>
        public ChecquingAccount(int acctNo = -1, string acctHolderName = "") :
            base(acctNo, acctHolderName)
        {
            //As the checquing account doesn't have any specific field variables there is nothing
            //to initialize. However the constructor is required in order to pass data provided
            //by client code to the base class through the base(..) call
        }

        /// <summary>
        /// The Annual Interest Rate mutator is overridden in order to verify that the annual interest rate is valid 
        /// for a checquing account when setting the interest rate
        /// </summary>
        /// <param name="annualIntrRate"></param>
        public override void SetAnnualIntrRate(float annualIntrRate)
        {
            //check to ensure the annual interest rate is valid for a checquing account

            //use the base class to set the annual interest rate
            base.SetAnnualIntrRate(annualIntrRate);
        }

        /// <summary>
        /// Withdraw the given amount from the account and return the new balance. The checquing account override
        /// the base implementation in order to implement overdraft functionality that checquing accounts have. This
        /// allows clients to withdraw more than the balance, up to the overdraft limit amount
        /// </summary>
        /// <param name="amount">the amount to be withdrawn, cannot be negative or greater than balance and overdraft combined</param>
        /// <returns>the new account balance AFTER the amount was deposited to avoid a call to getBalance() if needed</returns>
        public override double Withdraw(double amount)
        {
            //check the amount provided to ensure it is valid

            //check the overdraft on top of the actual balance

            //change the balance

            //provide the new balance to the caller to avoid a getBalance() call
            return 0;
        }
    }
}
