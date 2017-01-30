using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Xml.Serialization;

namespace AtmSharp
{
    /// <summary>
    /// Defines the valid account types that can be created by the user. Note that the 
    /// application creates default general accounts as well but the user can only create
    /// accounts designated through the enum values below.
    /// </summary>
    public enum AccountType
    {
        Chequing = 1,
        Savings
    }

    /// <summary>
    /// Defines a bank account its associated attributes and operations.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// the account number, read-only attribute
        /// </summary>
        private int _acctNo;

        /// <summary>
        /// the name of the account holder, read-only attribute
        /// </summary>
        private string _acctHolderName;

        /// <summary>
        /// the account balance that gets affected by withdrawls and deposits. Note the visibility
        /// of the field variable is set to "protected" to allow it to be accessed by derived classes.
        /// NOTE: the type is used as a double while the annual interest rate is float just to showcase
        /// the two floating point types. In practice financial application actually would use "decimals"
        /// which provide most precision.
        /// </summary>
        protected double _balance;

        /// <summary>
        /// the annual interest rate applicable on the balance.Note the visibility
        /// of the field variable is set to "protected" to allow it to be accessed by derived classes.
        /// </summary>
        protected float _annualIntrRate;

        /// <summary>
        /// Initialize the account object with its attributes.
        /// The account constructor requires the caller to supply an account number and
        /// the name of the account holder in order to create an account. 
        /// 
        /// NOTE: the constructor assigns default values to each parameter allowing the code
        /// not to supply them (i.e. acct = Account()). If the calling code does not supply
        /// values for the two parameters they will receive these default values. This is used
        /// when the accounts are created from data files 
        /// </summary>
        /// <param name="acctNo">the account number</param>
        /// <param name="acctHolderName">the name of the account holder</param>
        public Account(int acctNo = -1, string acctHolderName = "")
        {
            _acctNo = acctNo;
            _acctHolderName = acctHolderName;
            _balance = 0.0f;
            _annualIntrRate = 0.0f;
        }

    }
}
