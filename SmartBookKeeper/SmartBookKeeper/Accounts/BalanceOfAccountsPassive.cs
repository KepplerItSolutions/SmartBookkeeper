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
            Equity = new PassivAccount("Eigenkapital", this);
            Mortages = new PassivAccount("Hypothek", this);
            Loan = new PassivAccount("Darlehen", this);
            Liability = new PassivAccount("Verbindlichkeiten", this);
            SalesTaxes = new PassivAccount("Umsatzsteuer", this);

            this.AddRange(new Account[]
            {
                Equity,
                Mortages,
                Loan,
                Liability,
                SalesTaxes
            });
        }

        public Account Equity { get; set; }
        public Account Mortages { get; set; }
        public Account Loan { get; set; }
        public Account Liability { get; set; }
        public Account SalesTaxes { get; set; }
    }
}
