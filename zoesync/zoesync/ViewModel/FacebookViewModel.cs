using System.Threading.Tasks;
using zoesync.ServiceApp;
using zoesync.ViewModel.Base;

namespace zoesync.ViewModel
{
    public class FacebookViewModel : BaseViewModel
    {

        private FacebookProfile _facebookProfile;

        public FacebookProfile FacebookProfile
        {
            get { return _facebookProfile; }
            set
            {
                _facebookProfile = value;                     
            }
        }


        public async Task SetFacebookUserProfileAsync(string accessToken)
        {
            var facebookServices = new FacebookServices();

            FacebookProfile = await facebookServices.GetFacebookProfileAsync( accessToken );
        }
    }
}
