using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmSharp
{
    //NOTE: It is very much possible to have multiple classes defined in the same C# source file. In general though
    //the best practice is to define one class per file and to name the file and the class the same thing. In this
    //case there is valid reason to keep all these simple classes in one common place for clarity. If any one of these
    //classes would contain business logic they should be separated in individual files perhaps in specific namespace

    /// <summary>
    /// Exception class used when an invalid value is detected
    /// </summary>
    class InvalidValueException : Exception
    {
        public InvalidValueException(string message)
            : base(message)
        { }
    }

    /// <summary>
    /// Exception used when the user cancels an operation by pressing ENTER
    /// </summary>
    class OperationCanceledException : Exception
    {
        /// <summary>
        /// A default constructor that provides a default error message
        /// </summary>
        public OperationCanceledException(): base("The user has selected to cancel the current operation")
        {}

        public OperationCanceledException(string message)
            : base(message)
        { }
    }

    /// <summary>
    /// Exception class used when an invalid transaction is performed
    /// </summary>
    class InvalidTransactionException : Exception
    {
        public InvalidTransactionException(string message)
            : base(message)
        { }
    }

    /// <summary>
    /// Exception class used when an account is searched but not found in the bank
    /// </summary>
    class AccountNotFoundException : Exception
    {
        /// <summary>
        /// A default constructor that provides a default error message
        /// </summary>
        public AccountNotFoundException()
            : base("The account was not found. Please select another account.")
        { }

        /// <summary>
        /// Constructor allowing clients to pass an account number to provide a more precise error message
        /// </summary>
        /// <param name="acctNo"></param>
        public AccountNotFoundException(int acctNo)
            : base($"The account with account number {acctNo} was not found. Please select another account.")
        { }

        public AccountNotFoundException(string message): base(message)
        {}
    }

}
