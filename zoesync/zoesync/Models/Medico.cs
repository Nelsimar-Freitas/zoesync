using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoesync.Models
{
    public class Medico
    {
        
        public int IdMedico { get; set; }
        public string NomeMedico { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }
        public string UF { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
    }
}
