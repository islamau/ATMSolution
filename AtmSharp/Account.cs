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

        #region Accessor / Mutator Methods
        /// <summary>
        /// Accessor method for the account number that uniquely identifies the account in the bank.
        /// </summary>
        /// <returns>account number</returns>
        public int GetAccountNumber()
        {
            return _acctNo;
        }

        /// <summary>
        /// Mutator method for the account number that uniquely identifies the account in the bank.
        /// </summary>
        /// <param name="acctNo">new account number</param>
        public void SetAccountNumber(int acctNo)
        {
            _acctNo = acctNo;
        }

        /// <summary>
        /// Acessor method for the name of the account holder
        /// </summary>
        /// <returns>name of account holder</returns>
        public string GetAcctHolderName()
        {
            return _acctHolderName;
        }

        /// <summary>
        /// Mutator method for the name of the account holder
        /// </summary>
        /// <param name="acctHolderName">name of account holder</param>
        public void SetAcctHolderName(string acctHolderName)
        {
            _acctHolderName = acctHolderName;
        }

        /// <summary>
        /// Accessor method for the annual interest rate. 
        /// </summary>
        /// <returns>annual interest rate as a percentage</returns>
        public float GetAnnualIntrRate()
        {
            return _annualIntrRate * 100;
        }

        /// <summary>
        /// Mutator method for the annual interest rate.
        /// </summary>
        /// <param name="annualIntrRate">
        /// Annual interest rate as a whole percentage (e.g. 3 = 3% resulting in an interest rate of 0.03).
        /// </param>
        public virtual void SetAnnualIntrRate(float annualIntrRate)
        {
            //the value is expected to be a percentage. Not the "f" suffix which makes the 100 literal a "float"
            _annualIntrRate = annualIntrRate / 100f;
        }

        /// <summary>
        /// The monthly interest rate is a read-only property. Valued is derived from the annual interest rate
        /// </summary>
        /// <returns>monthly interest rate</returns>
        public float GetMonthlyIntrRate()
        {
            return _annualIntrRate / 12;
        }

        /// <summary>
        /// Accessor method for the balance of the account. Read-only property. The balance can be changed only via a banking tansaction
        /// such as a deposit or withdrawal
        /// </summary>
        /// <returns></returns>
        public double GetBalance()
        {
            return _balance;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deposit the given amount in the account and return the new balance. This method is polymorphic (defined as virtual)
        /// too allow specific (derived) account classes to override this base functionality
        /// </summary>
        /// <param name="initDepositAmount">the amount to be deposited</param>
        /// <returns>the new account balance AFTER the amount was deposited to avoid a call to the Balance.get if needed</returns>
        public virtual double Deposit(double amount)
        {
            //check that the amount is positive

            //change the balance

            //provide the new balance to the caller to avoid a getBalance() call
            return _balance;
        }

        /// <summary>
        /// Withdraw the given amount from the account and return the new balance. This method is polymorphic (defined as virtual)
        /// too allow specific (derived) account classes to override this base functionality
        /// </summary>
        /// <param name="amount">the amount to be withdrawn, cannot be negative or greater than available balance</param>
        /// <returns>the new account balance AFTER the amount was deposited to avoid a call to getBalance() if needed</returns>
        public virtual double Withdraw(double amount)
        {
            //ensure the amount provided is valid

            //change the balance

            //provide the new balance to the caller to avoid a getBalance() call
            return _balance;
        }

        /// <summary>
        /// Load the account information using the given stream reader object
        /// </summary>
        /// <param name="acctFileReader">file reader object to read the account file data</param>
        public void Load(StreamReader acctFileReader)
        {
            //read the account properties in the same order they were saved

        }

        /// <summary>
        /// Save the account information using the given stream writer object
        /// </summary>
        /// <param name="fileWriter">file writer object to write the account file data</param>
        public void Save(StreamWriter acctFileWriter)
        {
            //write the account properties, one per line

        }

        #endregion

    }
}
