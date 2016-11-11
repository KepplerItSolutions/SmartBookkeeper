using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem.Accounts.PassiveAccounts
{
    public class PassivAccount : Account
    {
        public PassivAccount(string name, Account parent)
            :base(name, parent)
        {

        }
    }
}
