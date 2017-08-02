using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class YesDoctorMedicDal
    {
        #region Médico
        public static List<medico> RetornaMedicos()
        {

            List<medico> listaMedicos = new List<medico>();

            try
            {
                using (var db = new yesdoctormedicEntities())
                {
                    listaMedicos = db.medico.Include("especialidade").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaMedicos;

        }

        public static int IncluirMedico(medico novoMedico)
        {
            using (var db = new yesdoctormedicEntities())
            {
                if (db.medico.FirstOrDefault(x => x.CRM == novoMedico.CRM) == null)
                {
                    db.medico.Add(novoMedico);
                    return db.SaveChanges();
                }
                else
                {
                    return 0;
                }
            }
        }
        #endregion

        #region Especialidade
        public static int RetornaIdEspecialidade(string descricao)
        {
            int idRetorno = 0;
            using (var db = new yesdoctormedicEntities())
            {
                especialidade espec = db.especialidade.Where(x => x.Descricao == descricao).FirstOrDefault();

                idRetorno = espec != null ? espec.idespecialidade : 0;
            }

            return idRetorno;
        }
        #endregion

        #region Agenda
        public static List<agenda> RetornaAgendas(int idMedico, int idLocal)
        {
            using (var db = new yesdoctormedicEntities())
            {
                return db.agenda.Where(x => x.idMedico == idMedico && x.idLocal == idLocal).ToList();
            }
        }

        public static int AlterarAgenda(agenda novaAgenda)
        {
            using (var db = new yesdoctormedicEntities())
            {
                agenda agendaAtualizar = db.agenda.FirstOrDefault(x => x.idagenda == novaAgenda.idagenda);

                if (agendaAtualizar == null)
                {
                    db.agenda.Add(novaAgenda);
                    return db.SaveChanges();
                }
                else
                {
                    agendaAtualizar.Data = novaAgenda.Data;
                    agendaAtualizar.DataInicio = novaAgenda.DataInicio;
                    agendaAtualizar.DataFim = novaAgenda.DataFim;
                    agendaAtualizar.Status = novaAgenda.Status;
                    
                    return db.SaveChanges();
                }
            }
        }

        public static int IncluirAgenda(agenda novaAgenda)
        {
            using (var db = new yesdoctormedicEntities())
            {
                if (db.agenda.FirstOrDefault(x => x.idLocal == novaAgenda.idLocal) == null)
                {
                    db.agenda.Add(novaAgenda);
                    return db.SaveChanges();
                }
                else
                {
                    return 0;
                }
            }
        }
        #endregion

        #region Local
        public static int AlterarLocal(local novoLocal)
        {
            using (var db = new yesdoctormedicEntities())
            {
                local localAtualizar = db.local.FirstOrDefault(x => x.idlocal == novoLocal.idlocal);

                if (localAtualizar == null)
                {
                    db.local.Add(novoLocal);
                    return db.SaveChanges();
                }
                else
                {
                    localAtualizar.Endereco = novoLocal.Endereco;
                    localAtualizar.Nome = novoLocal.Nome;
                    localAtualizar.Telefone = novoLocal.Telefone;
                    return db.SaveChanges();
                }
            }
        }

        public static int IncluirLocal(local novoLocal)
        {
            using (var db = new yesdoctormedicEntities())
            {
                if (db.local.FirstOrDefault(x => x.idMedico == novoLocal.idMedico) == null)
                {
                    db.local.Add(novoLocal);
                    return db.SaveChanges();
                }
                else
                {
                    return 0;
                }
            }
        }
        #endregion

    }
}
