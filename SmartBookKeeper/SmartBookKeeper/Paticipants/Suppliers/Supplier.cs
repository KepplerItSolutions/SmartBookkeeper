using SmartBookKeeper.BookingSystem.Paticipants.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem.Paticipants.Suppliers
{
    public class Supplier : Participant
    {
        public BankAccount BankData { get; set; }
    }
}
