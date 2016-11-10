using SmartBookKeeper.BookingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookGUI
{
    public class BalanceOfAccountsActive : Account
    {
        public BalanceOfAccountsActive()
            :base("Aktiva")
        {
            Buildings = new Account("Gebäude");
            Machines = new Account("Maschinen");
            CarPool = new Account("Fuhrpark");
            OfficeEquipement = new Account("Geschäftsausstattung");
            RawMaterials = new Account("Rohstoffe");
            AuxiliaryMaterials = new Account("Hilfsstoffe");
            Consumables = new Account("Betriebsstoffe");
            GoodsInProcess = new Account("Unfertige Erzeugnisse");
            FinishedProducts = new Account("Fertige Erzeugnisse");
            Receivables = new Account("Forderungen");
            Cash = new Account("Kasse");
            Bank = new Account("Bank");

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
