using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zoesync.ServiceApp
{
    public class ServiceAppLogin
    {
        public async Task<bool> Login(string email, string senha) {
            if( Validar( email, senha) )
            {    
                return true;  
            }
            else
            {
                //await Application.Current.MainPage.DisplayAlert( "Atenção", "Email e Senha são obrigatórios.", "OK" );
                return false;
            }
        }

        private bool Validar(string email, string senha)
        {
            return email != null && senha != null;
        }         
    }
}
