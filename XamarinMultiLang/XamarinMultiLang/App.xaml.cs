using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMultiLang.Localization;
using XamarinMultiLang.Resx;
using XamarinMultiLang.Views;

namespace XamarinMultiLang
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Device.Android == "Android" || Device.iOS == "iOS")
            {
                DependencyService.Get<ILocalize>().SetLocale();
                AppResources.Culture = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            }
            MainPage = new LocalizePageXaml();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
