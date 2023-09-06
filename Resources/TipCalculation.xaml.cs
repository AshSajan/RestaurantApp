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
    public partial class TipCalculation : PhoneApplicationPage
    {
        public static double tipAmount;
        public TipCalculation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            //Qty.bill += Convert.ToDouble(txtTipAmount.Text.ToString());

            tipAmount = Math.Round((Convert.ToDouble(txtTipAmount.Text) / 100) * Qty.bill , 2);
            MessageBox.Show("Tip Amount Added to Bill: " + tipAmount);

            Qty.bill += tipAmount;

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void TipSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtTipAmount.Text = Math.Round(TipSlider.Value, 2).ToString();
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}