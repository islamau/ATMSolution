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
    }
}
