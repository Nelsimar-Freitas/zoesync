using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Classes
{
    [DataContract]
    public class RetornoAgenda
    {
        [DataMember(Name = "idAgenda")]
        public int idagenda { get; set; }
        [DataMember(Name = "data")]
        public Nullable<System.DateTime> Data { get; set; }
        [DataMember(Name = "inicio")]
        public Nullable<System.DateTime> DataInicio { get; set; }
        [DataMember(Name = "fim")]
        public Nullable<System.DateTime> DataFim { get; set; }
        [DataMember(Name = "status")]
        public string Status { get; set; }
        [DataMember(Name = "idMedico")]
        public int idMedico { get; set; }
        [DataMember(Name = "idLocal")]
        public int idLocal { get; set; }
    }
}