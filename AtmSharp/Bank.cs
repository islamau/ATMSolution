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

        /// <summary>
        /// Load the account data for all the accounts. The account data files are stored in a directory
        /// named BankingData located in the current directory, the directory used to run the application from        
        /// </summary>
        public void LoadAccountData()
        {
            //get the directory path to the account files

            //get the list of files in the directory

            //go through the list of files, create the appropriate accounts and load the account files

            //if at this point the list of accounts is empty add the defaults accounts so the application is usable
        }

        /// <summary>
        /// Saves the data for all accounts in the data directory of the application. Each account is
        /// saved in a separate file which contains all the information and list of transactions performed
        /// in the account. The account data files are stored in a directory named BankingData located in the 
        /// current directory, the directory used to run the application from
        /// </summary>
        public void SaveAccountData()
        {
            //locate the path to the account files

            //make the directory if it does not exist

            //go through each account in the list of accounts and ask it to save itself into a corresponding file
        }

        /// <summary>
        /// Create 10 accounts with predefined IDs and balances. The default accounts are created only
        /// if no account data files exist
        /// </summary>
        private void CreateDefaultAccounts()
        {
            //repeat for as many default accounts need to be created
            {
                //create the account with required default properties

                //add the account to the list
            }

        }

        /// <summary>
        /// Create and store an account object with the required attributes
        /// </summary>
        /// <param name="clientName">the name of the account holder</param>
        /// <param name="acctType">the type of account to create</param>
        /// <returns>the account created</returns>
        public Account OpenAccount(string clientName, AccountType acctType)
        {
            //prompt the user for an account number

            //create and store an account object with the required attributes

            //add the new account to the list of the accounts

            //return the account to the caller so other properties can be set
            return null;
        }

        /// <summary>
        /// Determine the account number prompting the user until they enter the correct information.
        /// The method throws an OperationCancel exception if the user chooses to terminate.
        /// </summary>
        /// <returns></returns>
        private int DetermineAccountNumber()
        {
            //repeat trying to ask the user for the required input until the input is correct or the user cancels
            while (true)
            {
                //ask the user for input

                //check whether the user cancelled the operation

                //check the input to ensure correctness and deal with incorrect input

                //check that the account number is not in use

                //the account number has been generated successfully
                return 0;
            }
        }

        /// <summary>
        /// Returns the account with the given account number or null if no account with that ID can be found
        /// </summary>
        /// <param name="acctNo">the account number of the account to return</param>
        /// <returns>the account object with the given ID</returns>
        public Account FindAccount(int acctNo)
        {
            //go through all the accounts until one is found with the given account number

            //if the program got here it means there was no account with the given account number
            return null;
        }


    }
}
