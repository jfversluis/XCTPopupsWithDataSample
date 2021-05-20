using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace XCTPopupsWithDataSample
{
    public partial class MyPopup : Popup<PopupResult>
    {
        private PopupResult _result;
        public MyPopup(PopupResult result)
        {
            InitializeComponent();

            _result = result;
            myLabel.Text = _result.ReturnData;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            _result.ReturnData = "Return data from popup";
            Dismiss(_result);
        }
    }
}
