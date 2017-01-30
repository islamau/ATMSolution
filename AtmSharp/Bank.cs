using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AtmSharp
{
    /// <summary>
    /// Represents a bank composed of a list of accounts.
    /// </summary>
    public class Bank
    {
        /// <summary>
        /// the list of accounts managed by the bank
        /// </summary>
        private List<Account> _accountList;

        /// <summary>
        /// The first account number. New account numbers are generated using an incremental process
        /// starting with this number. The "const" keyword makes it impossible to change the value
        /// of the field variable
        /// </summary>
        private const int DEFAULT_ACCT_NO_START = 100;

        /// <summary>
        /// The name of the folder containing all the account files. The "const" keyword makes it impossible to change the value
        /// of the field variable 
        /// </summary>
        private const string BANKING_DATA_FOLDER = "BankingData";

        /// <summary>
        /// Prefix used for account files storing regular account data. The "const" keyword makes it impossible to change the value
        /// of the field variable 
        /// </summary>
        private const string ACCT_FILE_PREFIX = "acct";

        /// <summary>
        /// Prefix used for account files storing checquing account data. The "const" keyword makes it impossible to change the value
        /// of the field variable
        /// </summary>
        private const string CHQ_ACCT_FILE_PREFIX = "chqacct";

        /// <summary>
        /// Prefix used for account files storing savings account data. The "const" keyword makes it impossible to change the value
        /// of the field variable
        /// </summary>
        private const string SAV_ACCT_FILE_PREFIX = "savacct";

        /// <summary>
        /// Constructor used to create bank objects. The bank will have a list of accounts which is to storage of acccounts
        /// the application works with
        /// </summary>
        public Bank()
        {
            _accountList = new List<Account>();
        }

    }
}
