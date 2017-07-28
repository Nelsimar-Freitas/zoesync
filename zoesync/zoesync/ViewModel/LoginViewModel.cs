using Xamarin.Forms;
using zoesync.Page.MasterDetails;
using zoesync.ServiceApp;
using zoesync.ViewModel.Base;
using zoesync.ViewModel.Interfaces;

namespace zoesync.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private IViewModelBase _view;
        private ServiceAppLogin _serviceAppLogin;
        public LoginViewModel(IViewModelBase view) : base()
        {
            _view = view;
            _serviceAppLogin = new ServiceAppLogin();
        }


        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private Command _LoginCommand;
        public const string LoginCommandPropertyName = "LoginCommand";
        public Command LoginCommand
        {
            get { return _LoginCommand ?? ( _LoginCommand = new Command( Login ) ); }
        }

        private Command _RegisterCommand;
        public const string RegisterCommandPropertyName = "RegisterCommand";
        public Command RegisterCommand
        {
            get { return _RegisterCommand ?? (_RegisterCommand = new Command(Register)); }
        }

        void Register()
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => { Application.Current.MainPage = new CadastroMedico(); });
        }

        void Login()
        {

            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => { Application.Current.MainPage = new MainPage(); });

            //if ( _serviceAppLogin.Login( Email, Senha ).Result )
            //{
            //    //await Application.Current.MainPage.DisplayAlert( "Sucesso", "Login realizado com sucesso!", "OK" );

            //    Xamarin.Forms.Device.BeginInvokeOnMainThread( () => { Application.Current.MainPage = new MainPage (); } );
            //    //RootPage(); } );
            //}
            //else
            //{
            //    await Application.Current.MainPage.DisplayAlert( "Atenção", "Não foi possivel fazer Login, tente mais tarde!", "OK" );
            //}
        }
    }
}
