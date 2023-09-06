using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace RestaurantApplication
{
    public partial class Qty : PhoneApplicationPage
    {
        public static double bill;
        public static double curBill;
        public Qty()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            curBill = MainPage.currentPrice;

            if (txtQty.Text != string.Empty || txtQty.Text != "")
            {
                //bill += Convert.ToDouble(txtQty.Text) * Convert.ToDouble(mainPage.lblPrice1.Text);
                bill += Convert.ToDouble(txtQty.Text) * Convert.ToDouble(MainPage.currentPrice);
            }

            //mainPage.chkItem1.IsChecked = true;
            //mainPage.lblItem1.Text = "Selected";
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            //MessageBox.Show(bill.ToString());
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            lblItemName.Text = MainPage.currentItemName.ToString();
        }
    }
}