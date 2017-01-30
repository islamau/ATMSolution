using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AtmSharp
{
    /// <summary>
    /// Valid user choices for the main menu
    /// </summary>
    enum MainMenuOption
    {
        SelectAccount = 1,
        CreateAccount,
        ExitAtmApplication
    }

    /// <summary>
    /// Valid user choices for the account menu
    /// </summary>
    enum AccountMenuOption
    {
        CheckBalance = 1,
        Withdraw,
        Deposit,
        DisplayTransactions,
        ExitAccount
    }

    /// <summary>
    /// The Atm class representing an ATM machine. The class displays and performs the the account management functions
    /// on a given bank account: checking balance, withdrawing and depositing money
    /// </summary>
    /// <remarks>
    /// Author: Magdin Stoica
    /// Version 3.2 (C#)    
    /// </remarks>
    public class Atm
    {
        /// <summary>
        /// the bank this ATM object is working with
        /// </summary>
        private Bank _bank;

        /// <summary>
        /// Atm constructor that initializes the bank the ATM works with
        /// </summary>
        /// <param name="bank">the bank that manages the account objects the ATM works with</param>
        public Atm(Bank bank)
        {
            _bank = bank;
        }

        /// <summary>
        /// Starts the ATM program by displaying the required user options. 
        /// User navigates the menus managing their accounts
        /// </summary>
        public void Start()
        {
            //keep displaying the menu until the user chooses to exit the application
            while (true)
            {
                //display the main menu and perform the main actions depending on the user's choice

                //handle the user selection by calling the appropriate event handler method
            }
        }

        /// <summary>
        /// Displays the main ATM menu and ensure the user picks an option. Handles invalid input but doesn't check
        /// that the menu option is one of the displayed ones.
        /// </summary>
        /// <returns>the option selected by the user</returns>
        private MainMenuOption ShowMainMenu()
        {
            //Display menu and obtain selection from user. Return selected option.

            return MainMenuOption.ExitAtmApplication;
        }

        /// <summary>
        /// Displays the ACCOUNT menu that allows the user to perform account operations. Handles invalid input but doesn't check
        /// that the menu option is one of the displayed ones.
        /// </summary>
        /// <returns>the option selected by the user</returns>
        private AccountMenuOption ShowAccountMenu()
        {
            //Display menu and obtain selection from user. Return selected option.

            return AccountMenuOption.ExitAccount;
        }

        /// <summary>
        /// Create and open an account. The user is prompted for all account information including the type of account to open.
        /// Create the account object and add it to the bank
        /// </summary>
        private void OnCreateAccount()
        {
            //repeat trying to create an account until the user is successful or gives up
            while (true)
            {
                //get the name of the account holder from the user

                //get the initial deposit from the user

                //get the annual interest rate from the user

                //get the account type from the user

                //open the account

                //set the other account properties
            }
        }

        /// <summary>
        /// Select an account by prompting the user for an account number and remembering which account was selected.
        /// Prompt the user for performing account information such deposit and withdrawals
        /// </summary>
        /// <returns>
        ///     - the account object being selected or 
        ///     - null if the user cancelled; NOTE that this definition requires the caller to always use an if statement to check
        /// </returns>
        private Account OnSelectAccount()
        {
            //Attempt the user interaction  until all user information is provided correctly or the user cancels
            while (true)
            {
                //Prompt the user for the account number to select

                //check to see if the user gave up and is cancelling the operation                

                //the user entered an account number get the actual number

                //obtain the account required by the user from the bank

                return null;
            }
        }

        /// <summary>
        /// Manage the account by allowing the user to execute operation on the given account
        /// </summary>
        /// <param name="acct">the account to be managed</param>
        private void OnManageAccount(Account account)
        {
            //Attempt the user interaction  until all user information is provided correctly or the user cancels
            while (true)
            {
                //display menu and obtain a user selection

                //handle the user selection with the appropriate event handler
            }
        }

        /// <summary>
        /// Prompts the user to enter the name of the client and allows the user to cancel by pressing ENTER
        /// </summary>
        /// <returns>the name the client creating the account</returns>
        private string PromptForClientName()
        {
            //Prompt for teh client name

            //check whether the user input was valid

            return null;
        }

        /// <summary>
        /// Prompts the user to enter an account balance and performs basic error checking
        /// </summary>
        /// <returns>the amount to be deposited</returns>
        private double PromptForDepositAmount()
        {
            //repeat trying to ask the user for the required input until the input is correct or the user cancels
            while (true)
            {
                //Prompt for the initial balance

                //check the user input

                //if we got to this point the amount is valid
            }
        }

        /// <summary>
        /// Prompts the user to enter the annual interest rate for an account
        /// </summary>
        /// <returns>the annual interest rate for the account being created</returns>
        private float PromptForAnnualIntrRate()
        {
            //repeat trying to ask the user for the required input until the input is correct or the user cancels
            while (true)
            {
                //obtain the input from the user

                //perform basic sanity checking of the input. Note that the business rules for checking are implemented
                //in the account classes not here so that they are together with the rest of the account business logic

                //if we got to this point the amount is valid
            }
        }

        /// <summary>
        /// Prompts the user to enter an account type
        /// </summary>
        /// <returns>the account type as a constant as an enum value</returns>
        private AccountType PromptForAccountType()
        {
            //repeat trying to ask the user for the required input until the input is correct or the user cancels
            while (true)
            {
                //Prompt the user for the account type

                //determine the account type based on the user input

                return AccountType.Chequing;
            }
        }

        /// <summary>
        /// Prints the balance in the given account
        /// </summary>
        /// <param name="account">the account for which the balance is printed </param>
        private void OnCheckBalance(Account account)
        {
            //Display the current balance of the account
        }

        /// <summary>
        /// Prompts the user for an amount and performs the deposit. Handles any errors related to incorrect amounts
        /// </summary>
        /// <param name="account">the account in which the amount is to be deposited</param>
        private void OnDeposit(Account account)
        {
            //repeat trying to ask the user for the required input until the input is correct or the user cancels
            while (true)
            {
                //obtain the input amount from the user

                //test for empty input in case the user pressed [ENTER] because they wanted to give up on depositing money

                //the deposit was done or user entered nothing so break from the infinite loop
                return;
            }
        }

        /// <summary>
        /// Prompts the user for an amount and performs the withdrawal. Handles any errors related to incorrect amounts
        /// </summary>
        /// <param name="account">the account in which the amount is to be withdrawn</param>
        private void OnWithdraw(Account account)
        {
            //repeat trying to ask the user for the required input until the input is correct or the user cancels
            while (true)
            {
                //obtain the input amount from the user

                //test for empty input in case the user pressed [ENTER] because they wanted to give up on withdrawing money

                //the withdrawal was done or user entered nothing so break from the infinite loop
                return;
            }
        }

        /// <summary>
        /// Event handler called when the user selects to exit the application. Ensures that all account data is saved.
        /// </summary>
        private void OnExit()
        {
            //the application is shutting down, save all account information
        }

    }
}
