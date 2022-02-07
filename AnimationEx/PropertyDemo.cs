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
    class PropertyDemo:Activity
    {
       private Button fadinB;
       private  Button fadoutb;
        private Button zoomInb;
        private Button zoomoutb;
        private Button rotateInb;
        private Button rotateoutb;
        private ImageView imageP;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.propertyDemo);
            UIReference();
            UIClickEvents();


        }

        private void UIClickEvents()
        {
            fadinB.Click += FadinB_Click;
            fadoutb.Click += Fadoutb_Click;
            zoomInb.Click += ZoomInb_Click;
            zoomoutb.Click += Zoomoutb_Click;
            rotateInb.Click += RotateInb_Click;
            rotateoutb.Click += Rotateoutb_Click;
        }

        private void Rotateoutb_Click(object sender, EventArgs e)
        {
            var animation = AnimationUtils.LoadAnimation(this, Resource.Animation.antirotate);
            imageP.StartAnimation(animation);
        }

        private void RotateInb_Click(object sender, EventArgs e)
        {
            var animation = AnimationUtils.LoadAnimation(this, Resource.Animation.rotatein);
            imageP.StartAnimation(animation);
        }

        private void Zoomoutb_Click(object sender, EventArgs e)
        {
            var animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoomout);
            imageP.StartAnimation(animation);
        }

        private void ZoomInb_Click(object sender, EventArgs e)
        {
            var animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            imageP.StartAnimation(animation);
        }

        private void FadinB_Click(object sender, EventArgs e)
        {
            var animation = AnimationUtils.LoadAnimation(this, Resource.Animation.fade_in);
            imageP.StartAnimation(animation);
        }

        private void Fadoutb_Click(object sender, EventArgs e)
        {
            var animation = AnimationUtils.LoadAnimation(this, Resource.Animation.fadeout);
            imageP.StartAnimation(animation);
        }

        private void UIReference()
        {
            fadinB = FindViewById<Button>(Resource.Id.buttonP1);
            fadoutb = FindViewById<Button>(Resource.Id.buttonP2);
            zoomInb = FindViewById<Button>(Resource.Id.buttonP3);
            zoomoutb = FindViewById<Button>(Resource.Id.buttonP4);
            rotateInb = FindViewById<Button>(Resource.Id.buttonP5);
            rotateoutb = FindViewById<Button>(Resource.Id.buttonP6);
            imageP = FindViewById<ImageView>(Resource.Id.imageViewP);
        }
    }
}