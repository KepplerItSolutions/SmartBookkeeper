using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem
{
    public class Account : List<Account>, INotifyPropertyChanged
    {
        public Account(string name)
        {
            Name = name;
        }
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        string _name;

        public double Ammount
        {
            get
            {
                return _ammount;
            }
            set
            {
                if (_ammount != value)
                {
                    _ammount = value;
                    OnPropertyChanged("Ammount");
                }
            }
        }
        double _ammount;

        public Account this[string key]
        {
            get
            {
                Account result = null;

                foreach (Account itemAccount in this)
                {
                    if (itemAccount.Name == key)
                    {
                        result = itemAccount;
                    }
                }
                return result;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string Name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Name));
            }            
        }
    }
}
