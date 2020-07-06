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
    class ProdutoDao
    {
        string conecta = "server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey";
        MySqlConnection conexao = null;
        MySqlCommand comando;

        public DataTable Listar()
        {
            try
            {
                conexao = new MySqlConnection(conecta);

                comando = new MySqlCommand("select * from produto", conexao);

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

        public DataTable Estoque()
        {
            try
            {
                conexao = new MySqlConnection(conecta);

                comando = new MySqlCommand("select cod_prod, nome, quantidade from produto;", conexao);

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
        public DataTable Pesquisar(ProdutoModel produto)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(conecta);

                comando = new MySqlCommand("select * from produto where nome like '%' @nome '%' order by nome", conexao);

                comando.Parameters.AddWithValue("@nome", produto.Nome);

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
