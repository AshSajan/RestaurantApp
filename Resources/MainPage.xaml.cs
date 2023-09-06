using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RestaurantApplication.Resources;
using System.Windows.Controls.Primitives;
using System.ComponentModel;

namespace RestaurantApplication
{
    public partial class MainPage : PhoneApplicationPage
    {
        public static double currentPrice;
        public static string currentItemName;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void lblItem1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            currentPrice = Convert.ToDouble(lblPrice1.Text);
            currentItemName = "Enter Qty For " + lblItem1.Text.ToString();

            NavigationService.Navigate(new Uri("/Qty.xaml", UriKind.Relative));
        }

        private void ClearBackEntries()
        {
            while (NavigationService.BackStack != null & NavigationService.BackStack.Count() > 0)
                NavigationService.RemoveBackEntry();
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit?", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                this.ClearBackEntries();
            else
                e.Cancel = true;
        }

        private void btnTotalBill_Click(object sender, RoutedEventArgs e)
        {
            double newBill = Qty.bill + TipCalculation.tipAmount;
            MessageBox.Show("Total Bill including Tip : " + newBill.ToString() + "\n" + "Bill Per Guest: " + BillPerPerson.billPerPerson);
        }

        private void lblItem2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            Qty qtyPage = new Qty();

            currentPrice = Convert.ToDouble(lblPrice2.Text);
            currentItemName = "Enter Qty For " + lblItem2.Text.ToString();

            NavigationService.Navigate(new Uri("/Qty.xaml", UriKind.Relative));
        }

        private void lblItem4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            Qty qtyPage = new Qty();

            currentPrice = Convert.ToDouble(lblPrice4.Text);
            currentItemName = "Enter Qty For " + lblItem4.Text.ToString();

            NavigationService.Navigate(new Uri("/Qty.xaml", UriKind.Relative));
        }

        private void lblItem3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            Qty qtyPage = new Qty();

            currentPrice = Convert.ToDouble(lblPrice3.Text);
            currentItemName = "Enter Qty For " + lblItem3.Text.ToString();

            NavigationService.Navigate(new Uri("/Qty.xaml", UriKind.Relative));
        }

        private void lblItem5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            Qty qtyPage = new Qty();

            currentPrice = Convert.ToDouble(lblPrice5.Text);
            currentItemName = "Enter Qty For " + lblItem5.Text.ToString();

            NavigationService.Navigate(new Uri("/Qty.xaml", UriKind.Relative));
        }

        private void lblItem6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            Qty qtyPage = new Qty();

            currentPrice = Convert.ToDouble(lblPrice6.Text);
            currentItemName = "Enter Qty For " + lblItem6.Text.ToString();

            NavigationService.Navigate(new Uri("/Qty.xaml", UriKind.Relative));
        }

        private void lblItem7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            Qty qtyPage = new Qty();

            currentPrice = Convert.ToDouble(lblPrice7.Text);
            currentItemName = "Enter Qty For " + lblItem7.Text.ToString();

            NavigationService.Navigate(new Uri("/Qty.xaml", UriKind.Relative));
        }

        private void lblItem8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            Qty qtyPage = new Qty();

            currentPrice = Convert.ToDouble(lblPrice8.Text);
            currentItemName = "Enter Qty For " + lblItem8.Text.ToString();

            NavigationService.Navigate(new Uri("/Qty.xaml", UriKind.Relative));
        }

        private void lblItem9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            Qty qtyPage = new Qty();

            currentPrice = Convert.ToDouble(lblPrice9.Text);
            currentItemName = "Enter Qty For " + lblItem9.Text.ToString();

            NavigationService.Navigate(new Uri("/Qty.xaml", UriKind.Relative));
        }

        private void lblItem10_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            Qty qtyPage = new Qty();

            currentPrice = Convert.ToDouble(lblPrice10.Text);
            currentItemName = "Enter Qty For " + lblItem10.Text.ToString();

            NavigationService.Navigate(new Uri("/Qty.xaml", UriKind.Relative));
        }

        private void btnBillPerPerson_Click(object sender, RoutedEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;

            NavigationService.Navigate(new Uri("/BillPerPerson.xaml", UriKind.Relative));
        }

        private void btnTip_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TipCalculation.xaml", UriKind.Relative));
        }
    }
}