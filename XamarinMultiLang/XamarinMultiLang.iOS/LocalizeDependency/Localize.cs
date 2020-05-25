using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using Foundation;
using UIKit;
using XamarinMultiLang.iOS.LocalizeDependency;
using XamarinMultiLang.Localization;

[assembly: Xamarin.Forms.Dependency(typeof(Localize))]
namespace XamarinMultiLang.iOS.LocalizeDependency
{
    public class Localize : ILocalize
    {
        public CultureInfo GetCurrentCultureInfo()
        {
            var netLanguage = "en";
            var prefLang = "en";

            if (NSLocale.PreferredLanguages.Length > 0)
            {
                var pref = NSLocale.PreferredLanguages[0];
                prefLang = prefLang.Substring(0, 2);
                netLanguage = pref.Replace("_", "-");
            }

            CultureInfo ci = null;
            try
            {
                ci = new CultureInfo(netLanguage);
            }
            catch (Exception)
            {
                ci = new CultureInfo(prefLang);
            }
            return ci;
        }

        public void SetLocale()
        {
            var iosLocalAuto = NSLocale.AutoUpdatingCurrentLocale.LocaleIdentifier;
            var netLocale = iosLocalAuto.Replace("_", "-");
            CultureInfo ci;
            try
            {
                ci = new CultureInfo(netLocale);
            }
            catch (Exception)
            {
                ci = null;
            }
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}