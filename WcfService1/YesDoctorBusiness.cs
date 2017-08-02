using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.Classes;

namespace WcfService1
{
    public static class YesDoctorBusiness
    {
        #region Médicos
        public static List<RetornoMedico> RetornaMedicos()
        {
            List<RetornoMedico> listaRetorno = new List<RetornoMedico>();
            List<medico> listaMedicos = new List<medico>();

            listaMedicos = YesDoctorMedicDal.RetornaMedicos();

            if(listaMedicos.Count > 0)
            {
                foreach (var medico in listaMedicos)
                {
                    RetornoMedico novoMedico = new RetornoMedico();

                    novoMedico.CRM = medico.CRM;
                    novoMedico.NomeMedico = medico.NomeMedico;
                    novoMedico.Fone = medico.Fone;
                    novoMedico.UF = medico.UF;
                    novoMedico.Especialidade = medico.especialidade.Descricao;

                    listaRetorno.Add(novoMedico);
                }
            }

            return listaRetorno;
        }

        public static bool IncluirMedico(RetornoMedico medicoInclusao)
        {
            bool sucesso = false;
            medico novoMedico = new medico();
            try
            {
                novoMedico.CRM = medicoInclusao.CRM;
                novoMedico.NomeMedico = medicoInclusao.NomeMedico;
                novoMedico.Fone = medicoInclusao.Fone;
                novoMedico.UF = medicoInclusao.UF;
                novoMedico.Email = medicoInclusao.Email;
                novoMedico.idEspecialidade = RetornaIdEspecialidade(medicoInclusao.Especialidade);

                if (YesDoctorMedicDal.IncluirMedico(novoMedico) > 0)
                {
                    sucesso = true;
                }

            }
            catch (Exception ex)
            {
                sucesso = false;
            }

            return sucesso;
        }
        #endregion

        #region Agenda
        public static List<RetornoAgenda> RetornaAgendas(int idMedico, int idLocal)
        {
            List<RetornoAgenda> listaRetorno = new List<RetornoAgenda>();
            List<agenda> listaAgendas = new List<agenda>();

            listaAgendas = YesDoctorMedicDal.RetornaAgendas(idMedico, idLocal);

            if (listaAgendas.Count > 0)
            {
                foreach (var agenda in listaAgendas)
                {
                    RetornoAgenda novaAgenda = new RetornoAgenda();

                    novaAgenda.Data = agenda.Data;
                    novaAgenda.DataInicio = agenda.DataFim;
                    novaAgenda.DataFim = agenda.DataFim;
                    novaAgenda.Status = agenda.Status;

                    listaRetorno.Add(novaAgenda);
                }
            }

            return listaRetorno;
        }

        public static bool AlteraAgenda(RetornoAgenda agenda)
        {
            bool sucesso = false;
            agenda novaAgenda = new agenda();
            try
            {
                novaAgenda.Data = agenda.Data;
                novaAgenda.DataFim = agenda.DataFim;
                novaAgenda.DataInicio = agenda.DataInicio;
                novaAgenda.Status = agenda.Status;
                novaAgenda.idagenda = agenda.idagenda;
                novaAgenda.idMedico = agenda.idMedico;
                novaAgenda.idLocal = agenda.idLocal;

                if (YesDoctorMedicDal.AlterarAgenda(novaAgenda) > 0)
                {
                    sucesso = true;
                }
                else
                {
                    sucesso = false;
                }

            }
            catch (Exception ex)
            {
                sucesso = false;
            }
            return sucesso;
        }

        public static bool IncluirAgenda(RetornoAgenda agendaInclusao)
        {
            bool sucesso = false;
            agenda novaAgenda = new agenda();
            try
            {
                novaAgenda.Data = agendaInclusao.Data;
                novaAgenda.DataInicio = agendaInclusao.DataInicio;
                novaAgenda.DataFim = agendaInclusao.DataFim;
                novaAgenda.Status = agendaInclusao.Status;
                novaAgenda.idMedico = agendaInclusao.idMedico;
                novaAgenda.idLocal = agendaInclusao.idLocal;

                if (YesDoctorMedicDal.IncluirAgenda(novaAgenda) > 0)
                {
                    sucesso = true;
                }
            }
            catch (Exception ex)
            {
                sucesso = false;
            }

            return sucesso;

        }
        #endregion

        public static int RetornaIdEspecialidade(string descricao)
        {
            return YesDoctorMedicDal.RetornaIdEspecialidade(descricao);
        }
    }
}