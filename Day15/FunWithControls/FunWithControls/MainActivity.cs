using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace FunWithControls
{
    [Activity(Label = "FunWithControls", MainLauncher = false, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private CalendarView calendarView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            calendarView = FindViewById<CalendarView>(Resource.Id.calendarView1);

            calendarView.DateChange += CalendarView_DateChange;
            
            var getSelectedDateButton = FindViewById<Button>(Resource.Id.getSelectedDateButton);

            getSelectedDateButton.Click += GetSelectedDateButton_Click;

        }

        private void CalendarView_DateChange(object sender, CalendarView.DateChangeEventArgs e)
        {
            var newDayOfMonth = e.DayOfMonth;
            var newMonth = e.Month;
            var newYear = e.Year;
            //Do logic that needs to be done when date is changed.
        }

        private void GetSelectedDateButton_Click(object sender, EventArgs e)
        {
            var milliSeconds = calendarView.Date;

            var oldDateTime = new DateTime(1970, 1, 1);

            var newDate = oldDateTime.AddMilliseconds(milliSeconds);

            Toast.MakeText(this, newDate.ToShortDateString(), ToastLength.Long);
        }
    }
}


