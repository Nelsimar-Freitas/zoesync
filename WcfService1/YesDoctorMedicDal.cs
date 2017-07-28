using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class YesDoctorMedicDal : DbContext
    {
        }

        public static void Teste()
        {
            try
            {
                yesdoctormedicEntities db = new yesdoctormedicEntities();
                medico novoMedico = new medico();

                novoMedico.CRM = "asd";
                novoMedico.NomeMedico = "asd";

                db.medico.Add(novoMedico);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
    }
}