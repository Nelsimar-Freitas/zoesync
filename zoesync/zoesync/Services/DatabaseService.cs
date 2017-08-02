using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using zoesync.Models;

namespace zoesync.Services
{
    public class DatabaseService
    {
        public async Task<Medico> GetFacebookProfileAsync(string crm)
        {
            var requestUrl = 
                "https://graph.facebook.com/v2.7/me/?fields=name,picture,work,website,religion,location,locale,link,cover,age_range,bio,birthday,devices,email,first_name,last_name,gender,hometown,is_verified,languages&access_token="
                + crm;

            var httpClient = new HttpClient();

            var medico = await httpClient.GetStringAsync(requestUrl);

            var medicoRetorno = JsonConvert.DeserializeObject<Medico>(medico);

            return medicoRetorno;
        }
    }
}
