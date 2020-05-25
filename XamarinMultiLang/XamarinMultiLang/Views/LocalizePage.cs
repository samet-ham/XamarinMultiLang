using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

using Xamarin.Forms;
using XamarinMultiLang.Resx;

namespace XamarinMultiLang.Views
{
    public class LocalizePage : ContentPage
    {
        public LocalizePage()
        {
            Button btnSave = new Button
            {
                Text = AppResources.Save
            };
            btnSave.Clicked += (s, e) =>
            {
                DisplayAlert(AppResources.SuccessPopupTitle, AppResources.ErrorPopupMessage, AppResources.PopupButton);
            };

            Image imageIcon = new Image
            {
                Source = "icon.png"
            };

            StackLayout layout = new StackLayout
            {
                Children =
                {
                    btnSave,
                    imageIcon
                }
            };

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot()
                {
                    new TableSection(AppResources.FormName)
                    {
                        new EntryCell
                        {
                            Label = AppResources.Name,
                            Keyboard = Keyboard.Default
                        },
                        new EntryCell
                        {
                            Label = AppResources.Surname,
                            Keyboard = Keyboard.Default
                        },
                        new EntryCell
                        {
                            Label = AppResources.Password,
                            Keyboard = Keyboard.Numeric
                        },
                        new ViewCell() { View = layout}

                    }
                }
            };
            Content = tableView;
        }
    }
}