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
            :base("Passiva", "4000")
        {
            Equity = this.AddNewAccount("Eigenkapital", this, AccountType.Passive, "4001");
            Mortages = this.AddNewAccount("Hypothek", this, AccountType.Passive, "4002");
            Loan = this.AddNewAccount("Darlehen", this, AccountType.Passive, "4003");
            Liability = this.AddNewAccount("Verbindlichkeiten", this, AccountType.Passive, "4004");
            SalesTaxes = this.AddNewAccount("Umsatzsteuer", this, AccountType.Passive, "4005");
        }

        public Account Equity { get; set; }
        public Account Mortages { get; set; }
        public Account Loan { get; set; }
        public Account Liability { get; set; }
        public Account SalesTaxes { get; set; }
    }
}
