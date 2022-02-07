using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimationEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class DrawableDemo :Activity
    {

        private AnimationDrawable shindraw;
        private Button myButton;
        private ImageView myimageView;
        private Button myButtonStop;

 
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.drawDemo);
            UIReference();
            UIClickEvents();

            shindraw = (Android.Graphics.Drawables.AnimationDrawable)Resources.GetDrawable(Resource.Drawable.shinviews);
            myimageView.SetImageDrawable((Android.Graphics.Drawables.AnimationDrawable)shindraw);


        }

        private void UIClickEvents()
        {
            myButton.Click += MyButton_Click;
            myButtonStop.Click += MyButtonStop_Click;
        }

        private void MyButtonStop_Click(object sender, EventArgs e)
        {
            myimageView.Visibility = ViewStates.Invisible;
            shindraw.Stop();
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            myimageView.Visibility = ViewStates.Visible;
            shindraw.Start();
            
        }

       
        private void UIReference()
        {
            myButton = FindViewById<Button>(Resource.Id.buttonD);
            myimageView = FindViewById<ImageView>(Resource.Id.imageViewD);
            myButtonStop = FindViewById<Button>(Resource.Id.buttonDS);
          

        }
    }
}