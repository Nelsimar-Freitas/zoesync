using FacebookLogin.Views;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using zoesync.ViewModel;
using zoesync.ViewModel.Interfaces;

namespace zoesync.Page
{
    public partial class Flaty : ContentPage, IViewModelBase
    {
        public Flaty()
        {
            try
            {
                InitializeComponent();
            }
            catch( Exception ex )
            {
                var t = ex.Message;
            }

        }      
    }
}
