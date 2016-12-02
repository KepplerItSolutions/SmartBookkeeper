using SmartBookKeeper.BookingSystem.Accounts.ActiveAccounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem.Accounts
{
    public enum AccountType
    {
        Active,
        Passive
    }

    public class Account : List<Account>, INotifyPropertyChanged
    {
        public Account(string name)
        {
            Name = name;
            AccountNumber = accountNumber;
        }

        public Account(string name, string accountNumber, Account parent)
            :this(name, accountNumber)
        {
            ParentAccount = parent;
        }

        public AccountType TypeOfAccount { get; set; }
        public Account ParentAccount { get; set; }

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
                    ParentAccount?.RefreshSumOfAll();
                    OnPropertyChanged("Ammount");                    
                }
            }
        }
        double _ammount;

        public double SumOfAll
        {
            get { return _sumOfAll; }
            private set {
                if (value != _sumOfAll)
                {
                    _sumOfAll = value;
                    OnPropertyChanged("SumOfAll");
                }
            }
        }
        double _sumOfAll;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (value != _accountNumber)
                {
                    _accountNumber = value;
                    OnPropertyChanged("AccountNumber");
                }
            } }
        string _accountNumber;

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

        public void RefreshSumOfAll()
        {
            double lastValue = SumOfAll;
            SumOfAll = 0;
            foreach (Account itemAccount in this)
            {
                SumOfAll += itemAccount.Ammount;
            }
            if (lastValue != SumOfAll)
            {
                OnPropertyChanged("SumOfAll");
            }
        }

        public void Book(double ammount)
        {
            Ammount += ammount;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string Name)
        {
            var eventhandler = PropertyChanged;
            if (eventhandler != null)
            {
                eventhandler(this, new PropertyChangedEventArgs(Name));
            }            
            }            

        public Account AddNewAccount(string nameOfAccount, Account parant, AccountType typeOfAccount)
        {
            Account newAccount = new Account(nameOfAccount, parant);
            newAccount.TypeOfAccount = typeOfAccount;
            this.Add(newAccount);
            return newAccount;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
