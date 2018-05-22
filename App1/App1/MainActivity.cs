using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private Button Startknop;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            FindViews();
            HandleEvents();
        }
        private void FindViews()
        {
            Startknop = FindViewById<Button>(Resource.Id.startknop);
        }

        private void HandleEvents()
        {
            Startknop.Click += Startknop_Click;
        }

        private void Startknop_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(Login));
            StartActivity(intent);
        }
    }   

}

