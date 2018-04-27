using Android.App;
using Android.Widget;
using Android.OS;

namespace helloName.Droid
{
    [Activity(Label = "helloName", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
          
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            Button button = FindViewById<Button>(Resource.Id.myButton);
            TextView myTextView = FindViewById<TextView>(Resource.Id.helloWorldTextView);
            EditText inputName = FindViewById<EditText>(Resource.Id.inputName);

            button.Click += delegate { myTextView.Text = "Hello, " +  inputName.Text + "!"; };

        }
    }
}

