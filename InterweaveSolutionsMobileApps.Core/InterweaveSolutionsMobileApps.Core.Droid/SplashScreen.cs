using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace InterweaveSolutionsMobileApps.Core.Droid
{
    [Activity(
        MainLauncher = true,
        Label = "Interweave Solutions Success Ambassador Tools",
        NoHistory = true)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.Test)
        {

        }
    }
}