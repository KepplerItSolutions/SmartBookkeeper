using SmartBookKeeper.BookingSystem.Accounts;
using SmartBookKeeper.BookingSystem.Paticipants;
using System;

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

        public long ID { get; private set; }
        public String BillingNumber { get; private set; }
        public Account DebitAccount { get; private set; }
        public Account CreditAccount { get; private set; }
        public double Ammount { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime ValueDate { get; private set; }
        public DateTime BillingDate { get; private set; }
        public Participant PaticipanntOfBooking { get; private set; }
        public bool Booked { get; set; }

        public override string ToString()
        {
            return $"{CreationDate} {BillingNumber} {DebitAccount} {Ammount.ToString("C")} an {CreditAccount}\nWertstellung: {ValueDate}";
        }
    }
}
