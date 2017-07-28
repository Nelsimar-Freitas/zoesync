using CommonView.Animate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace zoesync.Page
{
    public partial class SplashScreenPage : ContentPage
    {
        public SplashScreenPage()
        {
            InitializeComponent();
        }

        //A tela foi exibida a fazer
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Indicator.IsRunning = true;
            //IMAGEVIEW-lo de desvio 50, 10 cada descendente, saltar cinco vezes
            await Animate.BallAnimate(this.logoImage,50,10,3);

            //Animação foi exibida para entrar na casa
            await Navigation.PushModalAsync( new LoginPage());
            //await Navigation.PushModalAsync( new Flaty() );

        }
    }
}
