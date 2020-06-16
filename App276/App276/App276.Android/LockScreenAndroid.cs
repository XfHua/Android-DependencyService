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
using App276.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(LockScreenAndroid))]
namespace App276.Droid
{
    public class LockScreenAndroid : ILockScreenService
    {
        public void lockScreen()
        {
            var second = new Intent(Android.App.Application.Context, typeof(LockScreenActivity));
            second.AddFlags(ActivityFlags.NewTask);
            Android.App.Application.Context.StartActivity(second);
        }
    }
}