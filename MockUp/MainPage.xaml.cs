using MockUp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MockUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DateTime SelectedDate;        
        
        public MainPage()
        {
            this.InitializeComponent();           
            Picker.Date = DateTime.Today;
            MyFrame.Navigate(typeof(DispatchList));
        }

        public void CalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            SelectedDate = sender.Date.Value.Date;
        }


        //private void MapListToggle_Click_1(object sender, RoutedEventArgs e)
        //{
        //    if (DisplayTitle.Text == "Dispatch List")
        //    {
        //        DisplayTitle.Text = "Map View";
        //        Frame.Navigate(typeof(MapView));
        //        MapListToggle.Content = "&#xE179;";
        //    }
        //    else
        //    {
        //        DisplayTitle.Text = "Dispatch List";
        //        Frame.Navigate(typeof(DispatchList));
        //        MapListToggle.Content = "&#xE139;";
        //    }
        //}

        private void HyperLinkClick_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(MapView));
        }
    }
}
