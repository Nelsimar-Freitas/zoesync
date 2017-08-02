using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.Classes;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet]
        List<RetornoMedico> RetornaMedicos();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Medico")]
        bool IncluirMedico(RetornoMedico medico);

    }
}