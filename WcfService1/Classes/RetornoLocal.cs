using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Classes
{
    [DataContract]
    public class RetornoLocal
    {
        [DataMember(Name ="idLocal")]
        public int idlocal { get; set; }
        [DataMember(Name = "nome")]
        public string Nome { get; set; }
        [DataMember(Name = "endereco")]
        public string Endereco { get; set; }
        [DataMember(Name = "telefone")]
        public string Telefone { get; set; }
        [DataMember(Name = "idMedico")]
        public Nullable<int> idMedico { get; set; }
    }
}