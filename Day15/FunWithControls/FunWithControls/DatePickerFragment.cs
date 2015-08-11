using System;
using Android.App;
using Android.Content;
using Android.OS;

namespace FunWithControls
{
    public class DatePickerFragment : DialogFragment
    {
        private readonly Context context;
        private  DateTime date;
        private readonly DatePickerDialog.IOnDateSetListener listener;

        public DatePickerFragment(Context context, DateTime date, DatePickerDialog.IOnDateSetListener listener  )
        {
            this.context = context;
            this.date = date;
            this.listener = listener;
        }

        public override Dialog OnCreateDialog(Bundle savedState)
        {
            var dialog = new DatePickerDialog(context, listener, date.Year, date.Month - 1, date.Day);
            return dialog;
        }
    }
}

