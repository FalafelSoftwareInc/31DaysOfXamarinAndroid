using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace FunWithControls
{
    [Activity(Label = "DatePickerSampleActivity", MainLauncher = false)]            
    public class DatePickerSampleActivity : Activity, DatePickerDialog.IOnDateSetListener
    {
        private TextView dateDisplay;
        private Button pickDate;
        private DateTime date;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.DatePickerSample);

             dateDisplay = FindViewById<TextView> (Resource.Id.dateDisplay);
             pickDate = FindViewById<Button> (Resource.Id.pickDate);

            // add a click event handler to the button
            pickDate.Click += delegate { ShowDatePickerDialog (); };

            // get the current date
            date = DateTime.Today;

            // display the current date (this method is below)
            UpdateDisplay (date);
        }

        void ShowDatePickerDialog()
        {
            var dialog = new DatePickerFragment(this, DateTime.Now, this);
            dialog.Show(FragmentManager, null);
        }
            
        public void OnDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth)
        {
            var newDate = new DateTime(year, monthOfYear + 1, dayOfMonth);
            UpdateDisplay(newDate);
        }

        void UpdateDisplay(DateTime selectedDate)
        {
            dateDisplay.Text = selectedDate.ToString("d");
        }
    }
}

