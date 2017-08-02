using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Classes
{
    [DataContract]
    public class RetornoMedico
    {
        [DataMember(Name ="id")]
        public int IdMedico { get; set; }
        [DataMember(Name = "nomeMedico")]
        public string NomeMedico { get; set; }
        [DataMember(Name = "crm")]
        public string CRM { get; set; }
        [DataMember(Name = "especialidade")]
        public string Especialidade { get; set; }
        [DataMember(Name = "uf")]
        public string UF { get; set; }
        [DataMember(Name = "email")]
        public string Email { get; set; }
        [DataMember(Name = "fone")]
        public string Fone { get; set; }
    }
}