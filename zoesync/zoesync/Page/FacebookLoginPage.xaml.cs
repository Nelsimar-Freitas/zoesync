using System;
using Xamarin.Forms;
using zoesync.ViewModel.Interfaces;

namespace zoesync.Page
{
    public partial class FacebookLoginPage : ContentPage, IViewModelBase
    {
        public FacebookLoginPage()
        {
            InitializeComponent();        
        }

        private async void LoginWithFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new FacebookProfilePage() );
        }
    }
}
