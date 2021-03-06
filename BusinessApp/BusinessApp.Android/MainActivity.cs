﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Views;
namespace BusinessApp.Droid
{
    [Activity(Label = "BusinessApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxActivity
    {

        /// <summary>
        /// Use OnViewModelSet to inflate the view's ContentView from AXML.
        /// </summary>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
          new App();
        }
        protected override void OnViewModelSet()
        {
            // This uses a resource identifier generated by Android to identify the view.
            SetContentView(Resource.Layout.Main);

        }
   
    }
}

