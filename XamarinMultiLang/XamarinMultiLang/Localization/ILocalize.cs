using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace XamarinMultiLang.Localization
{
    public interface ILocalize
    {
        void SetLocale();
        CultureInfo GetCurrentCultureInfo();
    }
}
