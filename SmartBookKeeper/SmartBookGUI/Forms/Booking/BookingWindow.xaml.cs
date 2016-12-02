using SmartBookKeeper.BookingSystem;
using SmartBookKeeper.BookingSystem.Accounts;
using System;
using System.Collections.Generic;
using System.Windows;

namespace SmartBookGUI.Forms.Booking
{
    /// <summary>
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        List<BookEntry> bookEntries;
        public BookingWindow(List<Account> accounts, List<BookEntry> entries)
        {                     
            InitializeComponent();

            bookEntries = entries;
            debitAccoutns.ItemsSource = accounts;
            debitAccoutns.DisplayMemberPath = "Name";

            creditAccounts.ItemsSource = accounts;
            creditAccounts.DisplayMemberPath = "Name";
        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            bookEntries.Add(new BookEntry("0815 RED", (Account)debitAccoutns.SelectedItem, (Account)creditAccounts.SelectedItem, double.Parse(tbAmmount.Text), DateTime.Now));
            this.Close();
        }
    }
}
