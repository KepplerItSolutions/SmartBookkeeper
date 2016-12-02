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
            Equity = new PassivAccount("Eigenkapital", "4001", this);
            Mortages = new PassivAccount("Hypothek", "4002", this);
            Loan = new PassivAccount("Darlehen", "4003", this);
            Liability = new PassivAccount("Verbindlichkeiten", "4004", this);
            SalesTaxes = new PassivAccount("Umsatzsteuer", "4005", this);

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
