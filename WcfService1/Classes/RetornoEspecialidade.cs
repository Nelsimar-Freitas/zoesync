using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Classes
{
    [DataContract]
    public class RetornoEspecialidade
    {
        [DataMember(Name = "id")]
        public int idespecialidade { get; set; }
        [DataMember(Name = "descricao")]
        public string Descricao { get; set; }
    }
}