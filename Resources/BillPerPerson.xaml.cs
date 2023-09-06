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
    public partial class BillPerPerson : PhoneApplicationPage
    {
        public static double billPerPerson;
        public BillPerPerson()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            billPerPerson = ((Qty.bill) + (TipCalculation.tipAmount)) / Convert.ToDouble(txtNoOfPerson.Text);
            MessageBox.Show("Bill Per Guest : " + billPerPerson.ToString());
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}