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

    //metodo para listar os dados do bd no data grid
    public class PessoaDao
    {
        string conecta = "server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey";
        MySqlConnection conexao = null;
        MySqlCommand comando;
        string date = DateTime.Today.ToString("dd/MM");

        public DataTable Listar()
        {
            try
            {
                conexao = new MySqlConnection(conecta);

                comando = new MySqlCommand("select * from dados", conexao);

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
        public DataTable Pesquisar(PessoaModel pessoa)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(conecta);

                comando = new MySqlCommand("select * from dados where nm_nome like '%' @nm_nome '%' order by nm_nome", conexao);

                comando.Parameters.AddWithValue("@nm_nome", pessoa.Nome);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarAniversario()
        {
            try
            {
                conexao = new MySqlConnection(conecta);

                comando = new MySqlCommand("select nm_nome as Nome, data_nascimento as Nascimento from dados where data_nascimento like '%" + date + "%'", conexao);

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


    }
}
