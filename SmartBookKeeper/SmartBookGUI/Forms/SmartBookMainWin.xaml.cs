using SmartBookGUI.Forms.Booking;
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
using System.Windows.Shapes;

namespace SmartBookGUI.Forms
{
    /// <summary>
    /// Interaction logic for SmartBookMainWin.xaml
    /// </summary>
    public partial class SmartBookMainWin : Window
    {
        public SmartBookMainWin()
        {
            InitializeComponent();
        }

        private void btnNewBooking_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.Width = (sender as Button).ActualWidth;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void mnuCreateOffer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuCreateBilling_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuCreateBooking_Click(object sender, RoutedEventArgs e)
        {
            CreateBooking window = new CreateBooking();
            window.Show();
        }
    }
}
