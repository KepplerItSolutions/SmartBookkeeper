using SmartBookKeeper.BookingSystem;
using SmartBookKeeper.BookingSystem.Accounts;
using SmartBookKeeper.BookingSystem.Accounts.PassiveAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem.Accounts
{
    public class BalanceOfAccountsPassive : Account
    {
        public BalanceOfAccountsPassive()
            :base("Passiva")
        {
            Equity = this.AddNewAccount("Eigenkapital", this, AccountType.Passive);
            Mortages = this.AddNewAccount("Hypothek", this, AccountType.Passive);
            Loan = this.AddNewAccount("Darlehen", this, AccountType.Passive);
            Liability = this.AddNewAccount("Verbindlichkeiten", this, AccountType.Passive);
            SalesTaxes = this.AddNewAccount("Umsatzsteuer", this, AccountType.Passive);
        }

        public Account Equity { get; set; }
        public Account Mortages { get; set; }
        public Account Loan { get; set; }
        public Account Liability { get; set; }
        public Account SalesTaxes { get; set; }
    }
}
