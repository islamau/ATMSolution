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
    }
}
