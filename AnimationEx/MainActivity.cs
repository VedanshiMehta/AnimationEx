using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AnimationEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button myViewDemo;
        Button myDrawabledemo;
        Button myPropertyDemo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            myViewDemo = FindViewById<Button>(Resource.Id.button1);
            myDrawabledemo = FindViewById<Button>(Resource.Id.button2);
            myPropertyDemo = FindViewById<Button>(Resource.Id.button3);


            myViewDemo.Click += MyViewDemo_Click;
            myDrawabledemo.Click += MyDrawabledemo_Click;
            myPropertyDemo.Click += MyPropertyDemo_Click;
        }

        private void MyPropertyDemo_Click(object sender, System.EventArgs e)
        {
            Intent k = new Intent(Application.Context, typeof(PropertyDemo));
            StartActivity(k);
        }

        private void MyDrawabledemo_Click(object sender, System.EventArgs e)
        {
            Intent j = new Intent(Application.Context, typeof(DrawableDemo));
            StartActivity(j);
        }

        private void MyViewDemo_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(Application.Context, typeof(ViewDemo));
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}