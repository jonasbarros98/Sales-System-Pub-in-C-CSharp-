using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudExemplos.Dao;
using CrudExemplos.Model;
using System.Data;

namespace CrudExemplos.Controller
{
    class AgendamentoController
    {
        public DataTable ListarAgendamento()
        {
            try
            {
                AgendamentoDao agendamentoDao = new AgendamentoDao();
                DataTable dt = new DataTable();

                dt = agendamentoDao.Listar();

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable Pesquisar(AgendamentoModel agendamento )
        {
            try
            {
                AgendamentoDao agendamentoDao = new AgendamentoDao();
                DataTable dt = new DataTable();

                dt = agendamentoDao.Pesquisar(agendamento);

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable PesquisarData(AgendamentoModel agendamento)
        {
             try
             {
                    AgendamentoDao agendamentoDao = new AgendamentoDao();
                    DataTable dt = new DataTable();

                    dt = agendamentoDao.PesquisarData(agendamento);

                    return dt;
             }
             catch (Exception)
             {
                    throw;
             }
        }
    }
}
