using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfService1;

namespace TestesWS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            YesDoctorBusiness.IncluirMedico(new WcfService1.Classes.RetornoMedico() { NomeMedico = "Teste", CRM = "123949", Email = "teste@teste", Especialidade = "CARDIOLOGIA", Fone = "9898989", UF = "RN" });
        }
    }
}
