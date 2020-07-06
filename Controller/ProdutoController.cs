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
    class ProdutoController
    {
        public DataTable ListarProd()
        {
            try
            {
                ProdutoDao produtoDao = new ProdutoDao();
                DataTable dt = new DataTable();

                dt = produtoDao.Listar();

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarEstoque()
        {
            try
            {
                ProdutoDao produtoDao = new ProdutoDao();
                DataTable dt = new DataTable();

                dt = produtoDao.Estoque();

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable Pesquisar(ProdutoModel produto)
        {
            try
            {
                ProdutoDao produtoDao = new ProdutoDao();
                DataTable dt = new DataTable();

                dt = produtoDao.Pesquisar(produto);

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
