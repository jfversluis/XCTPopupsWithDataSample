using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Extensions;

namespace XCTPopupsWithDataSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var popupResult = new PopupResult
            {
                ReturnData = "Initial data"
            };

            var result = await Navigation.ShowPopupAsync(new MyPopup(popupResult));

            await DisplayAlert("Result", $"Result: {result.ReturnData}", "OK");
        }
    }
}
