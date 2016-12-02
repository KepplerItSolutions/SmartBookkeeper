using SmartBookKeeper.BookingSystem;
using SmartBookKeeper.BookingSystem.Accounts;
using SmartBookKeeper.BookingSystem.Accounts.ActiveAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem.Accounts
{
    public class BalanceOfAccountsActive : Account
    {
        public BalanceOfAccountsActive()
            :base("Aktiva")
        {
            Buildings = this.AddNewAccount("Gebäude", this, AccountType.Active);
            Machines = this.AddNewAccount("Maschinen", this, AccountType.Active);
            CarPool = this.AddNewAccount("Fuhrpark", this, AccountType.Active);
            OfficeEquipement = this.AddNewAccount("Geschäftsausstattung", this, AccountType.Active);
            RawMaterials = this.AddNewAccount("Rohstoffe", this, AccountType.Active);
            AuxiliaryMaterials = this.AddNewAccount("Hilfsstoffe", this, AccountType.Active);
            Consumables = this.AddNewAccount("Betriebsstoffe", this, AccountType.Active);
            GoodsInProcess = this.AddNewAccount("Unfertige Erzeugnisse", this, AccountType.Active);
            FinishedProducts = this.AddNewAccount("Fertige Erzeugnisse", this, AccountType.Active);
            Receivables = this.AddNewAccount("Forderungen", this, AccountType.Active);
            Cash = this.AddNewAccount("Kasse", this, AccountType.Active);
            Bank = this.AddNewAccount("Bank", this, AccountType.Active);
        }
        public Account Buildings { get; set; }
        public Account Machines { get; set; }
        public Account CarPool { get; set; }
        public Account OfficeEquipement { get; set; }
        public Account RawMaterials { get; set; }
        public Account AuxiliaryMaterials { get; set; }
        public Account Consumables { get; set; }
        public Account GoodsInProcess { get; set; }
        public Account FinishedProducts { get; set; }
        public Account Receivables { get; set; }
        public Account Cash { get; set; }
        public Account Bank { get; set; }        
    }
}
