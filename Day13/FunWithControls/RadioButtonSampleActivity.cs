using Android.App;
using Android.OS;
using Android.Widget;

namespace FunWithControls
{
    [Activity(Label = "FunWithControls", MainLauncher = false, Icon = "@drawable/icon")]
    public class RadioButtonSampleActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.RadioButtonSample);

            var radioButton = FindViewById<RadioButton>(Resource.Id.radioButton);

            Toast.MakeText(this, radioButton.Checked.ToString(), ToastLength.Long).Show();

            radioButton.CheckedChange += radioButton_CheckedChange;

            var button = FindViewById<Button>(Resource.Id.button1);

            button.Click += button_Click;

        }

        void button_Click(object sender, System.EventArgs e)
        {
            var radioButtonGroup = FindViewById<RadioGroup>(Resource.Id.myRadioGroup);

            int selectedRadioButtonId = radioButtonGroup.CheckedRadioButtonId;

            var selectedRadioButton = FindViewById<RadioButton>(selectedRadioButtonId);

            Toast.MakeText(this, selectedRadioButton.Text, ToastLength.Long).Show();

        }

        void radioButton_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            Toast.MakeText(this, e.IsChecked.ToString(), ToastLength.Long).Show();
        }
    }
}

