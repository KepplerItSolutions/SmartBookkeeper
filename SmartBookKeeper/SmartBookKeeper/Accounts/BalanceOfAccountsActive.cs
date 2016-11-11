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
            Buildings = new ActiveAccount("Gebäude", this);
            Machines = new ActiveAccount("Maschinen", this);
            CarPool = new ActiveAccount("Fuhrpark", this);
            OfficeEquipement = new ActiveAccount("Geschäftsausstattung", this);
            RawMaterials = new ActiveAccount("Rohstoffe", this);
            AuxiliaryMaterials = new ActiveAccount("Hilfsstoffe", this);
            Consumables = new ActiveAccount("Betriebsstoffe", this);
            GoodsInProcess = new ActiveAccount("Unfertige Erzeugnisse", this);
            FinishedProducts = new ActiveAccount("Fertige Erzeugnisse", this);
            Receivables = new ActiveAccount("Forderungen", this);
            Cash = new ActiveAccount("Kasse", this);
            Bank = new ActiveAccount("Bank", this);

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
