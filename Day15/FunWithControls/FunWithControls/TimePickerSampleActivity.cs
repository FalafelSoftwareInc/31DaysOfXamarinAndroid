using Android.App;
using Android.OS;
using Android.Widget;

namespace FunWithControls
{
    [Activity(Label = "TimePickerSampleActivity", MainLauncher = true)]            
    public class TimePickerSampleActivity : Activity, TimePickerDialog.IOnTimeSetListener
    {
        private TextView timeDisplay;
        private Button pickTime;
        private int hours;
        private int minutes;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle); 

            // Create your application here
            SetContentView(Resource.Layout.TimePickerSample);

            timeDisplay = FindViewById<TextView> (Resource.Id.timeDisplay);
            pickTime = FindViewById<Button> (Resource.Id.pickTime);

            // add a click event handler to the button
            pickTime.Click += delegate { ShowTimePickerDialog (); };

            // get the current date
            hours = 2;
            minutes = 37;

            // display the current date (this method is below)
            UpdateDisplay (hours, minutes);

        }

        void ShowTimePickerDialog()
        {
            var dialog = new TimePickerFragment(this, hours, minutes, this);
            dialog.Show(FragmentManager, null); 
        }
            
        public void OnTimeSet(TimePicker view, int hourOfDay, int minute)
        {
            UpdateDisplay(hourOfDay, minute);
        }

        void UpdateDisplay(int selectedHours, int selectedMinutes)
        {
            timeDisplay.Text = selectedHours + ":" + selectedMinutes;
        }
    }
}

