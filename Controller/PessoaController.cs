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
    class PessoaController
    {
        public DataTable Listar()
        {
            try
            {
                PessoaDao pessoaDao = new PessoaDao();
                DataTable dt = new DataTable();

                dt = pessoaDao.Listar();

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

            public DataTable Pesquisar(PessoaModel pessoa)
             {
                try
                {
                    PessoaDao pessoaDao = new PessoaDao();
                    DataTable dt = new DataTable();

                    dt = pessoaDao.Pesquisar(pessoa);

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
                PessoaDao pessoaDao = new PessoaDao();
                DataTable dt = new DataTable();

                dt = pessoaDao.ListarAniversario();

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }


    }

