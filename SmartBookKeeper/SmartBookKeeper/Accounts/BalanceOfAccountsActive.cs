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
            :base("Aktiva", "0500")
        {
            Buildings = this.AddNewAccount("Gebäude", this, AccountType.Active, "0501");
            Machines = this.AddNewAccount("Maschinen", this, AccountType.Active, "0502");
            CarPool = this.AddNewAccount("Fuhrpark", this, AccountType.Active, "0503");
            OfficeEquipement = this.AddNewAccount("Geschäftsausstattung", this, AccountType.Active, "0504");
            RawMaterials = this.AddNewAccount("Rohstoffe", this, AccountType.Active, "0505");
            AuxiliaryMaterials = this.AddNewAccount("Hilfsstoffe", this, AccountType.Active, "0506");
            Consumables = this.AddNewAccount("Betriebsstoffe", this, AccountType.Active, "0507");
            GoodsInProcess = this.AddNewAccount("Unfertige Erzeugnisse", this, AccountType.Active, "0508");
            FinishedProducts = this.AddNewAccount("Fertige Erzeugnisse", this, AccountType.Active, "0509");
            Receivables = this.AddNewAccount("Forderungen", this, AccountType.Active, "0510");
            Cash = this.AddNewAccount("Kasse", this, AccountType.Active, "0511");
            Bank = this.AddNewAccount("Bank", this, AccountType.Active, "0512");
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
