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

namespace SmartBookGUI.Forms.Booking
{
    /// <summary>
    /// Interaction logic for CreateBooking.xaml
    /// </summary>
    public partial class CreateBooking : Window
    {
        public CreateBooking()
        {
            InitializeComponent();
            dpBillingDate.SelectedDate = DateTime.Now;
            dpTargetDate.SelectedDate = DateTime.Now;
        }

        private void btnSplittAmount_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.Width = (sender as Button).ActualWidth;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void mnuSplittBrutto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuSplittNetto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
            else if(e.Key == Key.Enter || e.Key == Key.Return)
            {
                CheckInputsAndSave();
            }
        }

        private void CheckInputsAndSave()
        {
            
        }
    }
}
