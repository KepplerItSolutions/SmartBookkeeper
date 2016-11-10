using SmartBookKeeper.BookingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartBookGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BalanceOfAccountsActive activa;
        BalanceOfAccountsPassive passiva;

        public MainWindow()
        {
            InitializeComponent();
            activa = new BalanceOfAccountsActive();
            activa.AuxiliaryMaterials.Ammount = 320000;
            activa.Bank.Ammount = 940000;
            activa.Buildings.Ammount = 6700000;
            activa.CarPool.Ammount = 300000;
            activa.Cash.Ammount = 30000;
            activa.Consumables.Ammount = 130000;
            activa.FinishedProducts.Ammount = 420000;
            activa.GoodsInProcess.Ammount = 250000;
            activa.Machines.Ammount = 2700000;
            activa.OfficeEquipement.Ammount = 450000;
            activa.RawMaterials.Ammount = 1200000;
            activa.Receivables.Ammount = 990000;

            passiva = new BalanceOfAccountsPassive();
            passiva.Equity.Ammount = 7740000;
            passiva.Liability.Ammount = 700000;
            passiva.Loan.Ammount = 1400000;
            passiva.Mortages.Ammount = 4500000;
            passiva.SalesTaxes.Ammount = 90000;
            AmmountToBook = 20000;

            tbAmmount.DataContext = this;
            tbLoan.DataContext = passiva;
            tbEquity.DataContext = passiva;
            tbMortages.DataContext = passiva;
            tbLiability.DataContext = passiva;
            tbSalesTaxes.DataContext = passiva;

            tbBuildings.DataContext = activa;
            tbMachines.DataContext = activa;
            tbCarPool.DataContext = activa;
            tbOfficeEquipement.DataContext = activa;
            tbRawMaterials.DataContext = activa;
            tbAuxiliaryMaterials.DataContext = activa;
            tbConsumables.DataContext = activa;
            tbGoodsInProcess.DataContext = activa;
            tbFinishedGoods.DataContext = activa;
            tbReceivables.DataContext = activa;
            tbCash.DataContext = activa;
            tbBank.DataContext = activa;
        }

        public double AmmountToBook { get; set; }

        private void btnAckBooking_Click(object sender, RoutedEventArgs e)
        {
            Account accountFrom = null;
            Account accountTo = null;

            accountFrom = activa[tbAccountFrom.Text];
            accountTo = activa[tbAccountTo.Text];

            accountFrom.Ammount += AmmountToBook;
            accountTo.Ammount -= AmmountToBook;
        }
    }
}
