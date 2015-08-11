using Android.App;
using Android.Content;
using Android.OS;

namespace FunWithControls
{
    public class TimePickerFragment : DialogFragment
    {
        private readonly Context context;
        private  int hour;
        private int minute;
        private readonly TimePickerDialog.IOnTimeSetListener listener;

        public TimePickerFragment(Context context, int hour, int minute, TimePickerDialog.IOnTimeSetListener listener  )
        {
            this.context = context;
            this.hour = hour;
            this.minute = minute;
            this.listener = listener;
        }

        public override Dialog OnCreateDialog(Bundle savedState)
        {
            var dialog = new TimePickerDialog(context, listener, hour, minute, false);
            return dialog;
        }
    }
}

