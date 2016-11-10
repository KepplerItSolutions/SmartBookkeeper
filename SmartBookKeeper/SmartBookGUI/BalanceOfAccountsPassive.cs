using SmartBookKeeper.BookingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookGUI
{
    public class BalanceOfAccountsPassive : List<Account>
    {
        public BalanceOfAccountsPassive()
        {
            Equity = new Account("Eigenkapital");
            Mortages = new Account("Hypothek");
            Loan = new Account("Darlehen");
            Liability = new Account("Verbindlichkeiten");
            SalesTaxes = new Account("Umsatzsteuer");

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
