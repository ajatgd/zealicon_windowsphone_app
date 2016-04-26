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
using listview_from_json_tutorial;
using Windows.ApplicationModel;
using Windows.UI.Popups;
using Windows.Networking.Connectivity;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace zealicon2016
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class cat3 : Page
    {

        public class RootObject
        {
            public int id { get; set; }
            public string event_id { get; set; }
            public string event_name { get; set; }
            public string event_description { get; set; }
            public string long_des { get; set; }
            public string rules { get; set; }
            public object __invalid_name__1st_place { get; set; }
            public object __invalid_name__2nd_place { get; set; }
            public string prize_money { get; set; }
            public string attachment { get; set; }
            public string timing { get; set; }
            public string contact { get; set; }
            public string approved { get; set; }
            public string grp { get; set; }
        }
        public cat3()
        {
            this.InitializeComponent();
            Loaded += new RoutedEventHandler(Page_Loaded);

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        async protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           

            if (NetworkInformation.GetInternetConnectionProfile() == null)
            {
                //no connection
                MessageDialog msgbox = new MessageDialog("SPIDEE spider wants you to wait or check your internet connection");
                //Calling the Show method of MessageDialog class  
                //which will show the MessageBox  
                await msgbox.ShowAsync();
            }
            else
            {
                MessageDialog msgbox= new MessageDialog("PLease wait.....Your wait will be worth.....SPIDEE spider is fetching data");
                await msgbox.ShowAsync();
            }
        }

        void Page_Loaded(object sender, RoutedEventArgs e)
        {
            download_data dwl = new download_data();

            dwl.downloadDatacomplete += data_arrived;
            dwl.get_data("http://zealbo.hackncs.com/events/2.json");
        }
        async void message()
        {
            MessageDialog msgbox = new MessageDialog("Sorry there is some technical problem");
            //Calling the Show method of MessageDialog class  
            //which will show the MessageBox  
            await msgbox.ShowAsync();
        }

        void data_arrived(object sender, DownloadCompleteData e)
        {

            String data = e.data;

            JArray obj = JArray.Parse(data);


            try
            {

                JObject row = JObject.Parse(obj[0].ToString());

                t.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t1.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t2.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t3.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim();

                t4.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t5.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t6.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();



            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }


            try
            {
                JObject row = JObject.Parse(obj[1].ToString());
                t8.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t9.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t10.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t11.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t12.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t13.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t14.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;



            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }
            try
            {
                JObject row = JObject.Parse(obj[2].ToString());
                t16.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t17.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t18.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t19.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t20.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t21.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t22.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;


            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }
            try
            {
                JObject row = JObject.Parse(obj[3].ToString());
                t24.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t25.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t26.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t27.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t28.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;

                t29.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t30.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;




            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }
            try
            {
                JObject row = JObject.Parse(obj[4].ToString());
                t32.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t33.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t34.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t39.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t37.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t35.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t36.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;



            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }
            try
            {
                JObject row = JObject.Parse(obj[5].ToString());
                t40.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t41.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t42.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t47.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t45.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;

                t43.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t44.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;


            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }
            try
            {
                JObject row = JObject.Parse(obj[6].ToString());
                t48.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t49.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t50.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t55.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t53.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;

                t51.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t52.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;


            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }
            try
            {
                JObject row = JObject.Parse(obj[7].ToString());
                t56.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t57.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t58.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t63.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t61.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;

                t59.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t60.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;


            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }
            try
            {
                JObject row = JObject.Parse(obj[8].ToString());
                t64.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t65.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t66.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t71.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t69.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;

                t67.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t68.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;


            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }
            try
            {
                JObject row = JObject.Parse(obj[9].ToString());
                t72.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t73.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t74.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t79.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t77.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;

                t75.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t76.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;


            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }
            try
            {
                JObject row = JObject.Parse(obj[10].ToString());
                t80.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t81.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t82.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t87.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t85.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;

                t83.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t84.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;


            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }
            try
            {
                JObject row = JObject.Parse(obj[11].ToString());
                t88.Text = Regex.Replace(row["event_name"].ToString(), @"<[^>]+>|&nbsp;", "").Trim();
                t89.Text = Regex.Replace(row["long_des"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t90.Text = Regex.Replace(row["rules"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t95.Text = Regex.Replace(row["prize_money"].ToString(), @"[^0-9a-zA-Z\,]+", "").Trim(); ;
                t93.Text = Regex.Replace(row["timing"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;

                t91.Text = Regex.Replace(row["__invalid_name__1st_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;
                t92.Text = Regex.Replace(row["__invalid_name__2nd_place"].ToString(), @"<[^>]+>|&nbsp;", "").Trim(); ;


            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    message();
                }
            }

            

            
        }
    }
}
