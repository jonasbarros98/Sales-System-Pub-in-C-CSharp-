using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudExemplos.Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace CrudExemplos.Dao
{
    class AgendamentoDao
    {
        string conecta = "server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey";
        MySqlConnection conexao = null;
        MySqlCommand comando;
        string date = DateTime.Today.ToString("yyyy-MM-dd");
       
        public DataTable Listar()
        {
            try
            {
                conexao = new MySqlConnection(conecta);

                comando = new MySqlCommand("select * from agendamentos where Data = '"+date+"'", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;

            }
            catch (Exception)
            {
                throw;
            }
        }
        //metodo para pesquisar ao digitar
        public DataTable Pesquisar(AgendamentoModel agendamento)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(conecta);

                comando = new MySqlCommand("select * from agendamentos where Funcionario like '%' @Funcionario '%' and Status like '%' @Status '%' and Data like '%' @Data '%'", conexao);

                comando.Parameters.AddWithValue("@Funcionario", agendamento.Funcionario);
                comando.Parameters.AddWithValue("@Status", agendamento.Status);
                comando.Parameters.AddWithValue("@Data", agendamento.Data);

                da.SelectCommand = comando;
                da.Fill(dt);

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
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(conecta);

                comando = new MySqlCommand("select * from agendamentos where Data like '%' @Data '%'", conexao);

                comando.Parameters.AddWithValue("@Data", agendamento.Data);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
