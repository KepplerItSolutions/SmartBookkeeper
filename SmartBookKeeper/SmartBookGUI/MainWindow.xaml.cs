using SmartBookKeeper.BookingSystem;
using SmartBookKeeper.BookingSystem.Accounts;
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
        StockAccounts _stockAccounts;

        public MainWindow()
        {
            InitializeComponent();
            _stockAccounts = new StockAccounts();

            _stockAccounts.ActivaAccounts.AuxiliaryMaterials.Ammount = 320000;
            _stockAccounts.ActivaAccounts.Bank.Ammount = 940000;
            _stockAccounts.ActivaAccounts.Buildings.Ammount = 6700000;
            _stockAccounts.ActivaAccounts.CarPool.Ammount = 300000;
            _stockAccounts.ActivaAccounts.Cash.Ammount = 30000;
            _stockAccounts.ActivaAccounts.Consumables.Ammount = 130000;
            _stockAccounts.ActivaAccounts.FinishedProducts.Ammount = 420000;
            _stockAccounts.ActivaAccounts.GoodsInProcess.Ammount = 250000;
            _stockAccounts.ActivaAccounts.Machines.Ammount = 2700000;
            _stockAccounts.ActivaAccounts.OfficeEquipement.Ammount = 450000;
            _stockAccounts.ActivaAccounts.RawMaterials.Ammount = 1200000;
            _stockAccounts.ActivaAccounts.Receivables.Ammount = 990000;

            _stockAccounts.PassivaAccounts.Equity.Ammount = 7740000;
            _stockAccounts.PassivaAccounts.Liability.Ammount = 700000;
            _stockAccounts.PassivaAccounts.Loan.Ammount = 1400000;
            _stockAccounts.PassivaAccounts.Mortages.Ammount = 4500000;
            _stockAccounts.PassivaAccounts.SalesTaxes.Ammount = 90000;
            AmmountToBook = 20000;

            tbAmmount.DataContext = this;
            tbLoan.DataContext = _stockAccounts.PassivaAccounts;
            tbEquity.DataContext = _stockAccounts.PassivaAccounts;
            tbMortages.DataContext = _stockAccounts.PassivaAccounts;
            tbLiability.DataContext = _stockAccounts.PassivaAccounts;
            tbSalesTaxes.DataContext = _stockAccounts.PassivaAccounts;
            tbSumPassiva.DataContext = _stockAccounts.PassivaAccounts;

            tbBuildings.DataContext = _stockAccounts.ActivaAccounts;
            tbMachines.DataContext = _stockAccounts.ActivaAccounts;
            tbCarPool.DataContext = _stockAccounts.ActivaAccounts;
            tbOfficeEquipement.DataContext = _stockAccounts.ActivaAccounts;
            tbRawMaterials.DataContext = _stockAccounts.ActivaAccounts;
            tbAuxiliaryMaterials.DataContext = _stockAccounts.ActivaAccounts;
            tbConsumables.DataContext = _stockAccounts.ActivaAccounts;
            tbGoodsInProcess.DataContext = _stockAccounts.ActivaAccounts;
            tbFinishedGoods.DataContext = _stockAccounts.ActivaAccounts;
            tbReceivables.DataContext = _stockAccounts.ActivaAccounts;
            tbCash.DataContext = _stockAccounts.ActivaAccounts;
            tbBank.DataContext = _stockAccounts.ActivaAccounts;
            tbSumActiva.DataContext = _stockAccounts.ActivaAccounts;
        }

        public double AmmountToBook { get; set; }

        private void btnAckBooking_Click(object sender, RoutedEventArgs e)
        {
            _stockAccounts.Book(tbAccountFrom.Text, tbAccountTo.Text, AmmountToBook);
        }
    }
}
