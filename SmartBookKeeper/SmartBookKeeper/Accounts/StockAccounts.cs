using SmartBookKeeper.BookingSystem.Accounts.ActiveAccounts;
using SmartBookKeeper.BookingSystem.Accounts.PassiveAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem.Accounts
{
    public class StockAccounts
    {
        public StockAccounts()
        {
            ActivaAccounts = new BalanceOfAccountsActive();
            PassivaAccounts = new BalanceOfAccountsPassive();
        }

        public BalanceOfAccountsActive ActivaAccounts { get; set; }
        public BalanceOfAccountsPassive PassivaAccounts { get; set; }

        public Account this[string key]
        {
            get {
                Account result = null;
                foreach (Account itemActiveAccount in ActivaAccounts)
                {
                    if (itemActiveAccount.Name == key)
                    {
                        result = itemActiveAccount;
                    }
                }

                if (result == null)
                {
                    foreach (Account itemPassiveAccounts in PassivaAccounts)
                    {
                        if (itemPassiveAccounts.Name == key)
                        {
                            result = itemPassiveAccounts;
                        }
                    }

                }
                return result;
            }
        }

        public void Book(string debitName, string creditName, double ammount)
        {
            Account creditAccount = this[creditName];
            Account debitAccount = this[debitName];

            if (debitAccount is ActiveAccount)
            {
                debitAccount.Ammount += ammount;
            }
            else
            {
                debitAccount.Ammount -= ammount;
            }

            if (creditAccount is ActiveAccount)
            {
                creditAccount.Ammount -= ammount;
            }
            else
            {
                creditAccount.Ammount += ammount;
            }
        }
    }
}
