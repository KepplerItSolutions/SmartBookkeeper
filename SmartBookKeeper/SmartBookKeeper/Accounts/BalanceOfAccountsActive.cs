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
            Buildings = new ActiveAccount("Gebäude", "0501", this);
            Machines = new ActiveAccount("Maschinen", "0502", this);
            CarPool = new ActiveAccount("Fuhrpark", "0503", this);
            OfficeEquipement = new ActiveAccount("Geschäftsausstattung", "0504", this);
            RawMaterials = new ActiveAccount("Rohstoffe", "0505", this);
            AuxiliaryMaterials = new ActiveAccount("Hilfsstoffe", "0506", this);
            Consumables = new ActiveAccount("Betriebsstoffe", "0507", this);
            GoodsInProcess = new ActiveAccount("Unfertige Erzeugnisse", "0508", this);
            FinishedProducts = new ActiveAccount("Fertige Erzeugnisse", "0509", this);
            Receivables = new ActiveAccount("Forderungen", "0510", this);
            Cash = new ActiveAccount("Kasse", "0511", this);
            Bank = new ActiveAccount("Bank","0512", this);

            this.AddRange(new Account[] {
                Buildings,
                Machines,
                CarPool,
                OfficeEquipement,
                RawMaterials,
                AuxiliaryMaterials,
                Consumables,
                GoodsInProcess,
                FinishedProducts,
                Receivables,
                Cash,
                Bank                
            });

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
