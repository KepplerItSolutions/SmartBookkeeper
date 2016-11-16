using SmartBookKeeper.BookingSystem.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem
{
    public class BookEntry
    {
        public BookEntry(string billingNumber, Account debitAccount, Account creditAccount, double ammount, DateTime valueDate)
        {
            BillingNumber = billingNumber;
            DebitAccount = debitAccount;
            CreditAccount = creditAccount;
            Ammount = ammount;
            ValueDate = valueDate;
            CreationDate = DateTime.Now;
        }

        public String BillingNumber { get; private set; }
        public Account DebitAccount { get; private set; }
        public Account CreditAccount { get; private set; }
        public double Ammount { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime ValueDate { get; private set; }

        public override string ToString()
        {
            return $"{CreationDate} {BillingNumber} {DebitAccount} {Ammount.ToString("C")} an {CreditAccount}\nWertstellung: {ValueDate}";
        }
    }
}
