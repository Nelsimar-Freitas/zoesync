﻿using FacebookLogin.Views;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using zoesync.ViewModel;
using zoesync.ViewModel.Interfaces;

namespace zoesync.Page
{
    public partial class LoginPage : ContentPage, IViewModelBase
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel( this );





            //var apiResult = "https://www.facebook.com/dialog/oauth?client_id="
            //    + 1907744339462844
            //    + "&response_type=token&redirect_uri=https://www.facebook.com/connect/login_success.html";

            //var webView = new WebView
            //{
            //    Source = apiResult,
            //    HeightRequest = 1
            //};

            //webView.Navigated += WebViewOnNavigated;

            //Content = webView;

        }


        async void LoginComFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new FacebookLoginPage() );
        }

        private async void WebViewOnNavigated(object sender, WebNavigatedEventArgs e)
        {
            var accessToken = ExtractAcessTokenFromUrl( e.Url );

            if( accessToken != "" )
            {
                await GetFacebookProfileAsync( accessToken );
            }
        }

        private async Task GetFacebookProfileAsync(string accessToken)
        {
            var requestUrl =
                 "https://graph.facebook.com/v2.7/me/?fields=name,picture,work,website,religion,location,locale,link,cover,age_range,bio,birthday,devices,email,first_name,last_name,gender,hometown,is_verified,languages&access_token="
                 + accessToken;

            var httpClient = new HttpClient();

            var userJson = await httpClient.GetStringAsync( requestUrl );
        }

        private string ExtractAcessTokenFromUrl(string url)
        {
            if( url.Contains( "access_token" ) && url.Contains( "&expires_in=" ) )
            {
                var at = url.Replace( "https://www.facebook.com/connect/login_success.html#access_token=", "" );

                if( Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows )
                {
                    at = url.Replace( "https://www.facebook.com/connect/login_success.html#access_token=", "" );
                }

                var accessToken = at.Remove( at.IndexOf( "&expires_in=" ) );

                return accessToken;
            }
            return string.Empty;
        }
    }
}
