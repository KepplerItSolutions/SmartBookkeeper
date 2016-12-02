using SmartBookKeeper.BookingSystem.Paticipants.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem.Paticipants
{
    public class Participant
    {
        public string CompanyName { get; set; }
        public Address MainAddress { get; set; }
        public long ID { get; set; }
    }
}
