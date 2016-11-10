using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem
{
    public class Account
    {
        public Account(string name)
        {
            Name = name;
        }
        public String Name { get; set; }
        public double Ammount { get; set; }
    }
}
