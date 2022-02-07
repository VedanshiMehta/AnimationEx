using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimationEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class ViewDemo : Activity
    {
        private Button buttonAnimate;
        private LinearLayout myView;
        private bool _expanded;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.viewDemo);
            UIReference();
            UIClickEvents();
        }

        private void UIClickEvents()
        {
            buttonAnimate.Click += ButtonAnimate_Click;
        }

        private void ButtonAnimate_Click(object sender, EventArgs e)
        {
            if (_expanded)
            {
                SlideUp();
                _expanded = true;
            }

           else
            {
                SlidDown();
                _expanded = false;
            }
        }

        private void SlidDown()
        {
            myView.Visibility = ViewStates.Invisible;
            TranslateAnimation animate = new TranslateAnimation(

                0,
                0,
                0,
                myView.Height);
            animate.Duration = 500;
            myView.StartAnimation(animate);
        }

        private void SlideUp()
        {
            myView.Visibility = ViewStates.Visible;
            TranslateAnimation animate = new TranslateAnimation(

                0,
                0,
                myView.Height,
                0);
            animate.Duration = 1000;
            myView.StartAnimation(animate);
        }

        private void UIReference()
        {
            buttonAnimate = FindViewById<Button>(Resource.Id.buttonA);
            myView = FindViewById<LinearLayout>(Resource.Id.linearLayoutA);
        }
    }
}