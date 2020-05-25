using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XamarinMultiLang.Droid.LocalizeDependency;
using XamarinMultiLang.Localization;

[assembly: Xamarin.Forms.Dependency(typeof(Localize))]
namespace XamarinMultiLang.Droid.LocalizeDependency
{
    public class Localize : ILocalize
    {
        public CultureInfo GetCurrentCultureInfo()
        {
            var androidLocal = Java.Util.Locale.Default;
            var netLocale = androidLocal.ToString().Replace("_", "-");

            return new CultureInfo(netLocale);
        }

        public void SetLocale()
        {
            var androidLocal = Java.Util.Locale.Default;
            var netLocale = androidLocal.ToString().Replace("_", "-");
            var ci = new CultureInfo(netLocale);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}