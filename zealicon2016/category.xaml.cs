using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace zealicon2016
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class category : Page
    {
        public category()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        private void SecondaryButton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(about));
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(cat1));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(cat2));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(cat3));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(cat4));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(cat5));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(cat6));
        }

        private void location_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(location));

        }

        private void SecondaryButton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(contact_us));
        }
        private void SecondaryButton3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(sponsors));
        }
    }
}
