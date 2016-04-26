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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using listview_from_json_tutorial;
using Windows.UI.Popups;
using Windows.Networking.Connectivity;
using System.Windows;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace zealicon2016
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        

       



        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }


       


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
       async protected override void OnNavigatedTo(NavigationEventArgs e)
        {

           // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
            if (NetworkInformation.GetInternetConnectionProfile() == null)
            {
                MessageDialog msgbox = new MessageDialog("Please turn on your internet connection to get updated status of events.");
                //Calling the Show method of MessageDialog class  
                //which will show the MessageBox  
                await msgbox.ShowAsync();

        

            }
        }
        private void AddAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(category));

        }

        private void SecondaryButton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(about));
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
