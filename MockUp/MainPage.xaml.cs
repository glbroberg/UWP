using MockUp.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MockUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        String DisplayTitle = "dipatch List";
        DateTime SelectedDate;
        private List<Dispatch> Dispatches;
        //List<Dispatch> Dispatch2 = new List<Dispatch>();

        public MainPage()
        {
            this.InitializeComponent();
            Dispatches = DispatchManger.GetDispatches();
            Picker.Date = DateTime.Today;
        }

        private void CalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            SelectedDate = sender.Date.Value.Date;
            //DateSelectedText.Text = "You picked: " + SelectedDate.ToString();
            var Dispatches2 = Dispatches.Where(x => x.ScheduleDate == SelectedDate);            
            
        }
    }
}
