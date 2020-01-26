using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace CrudExemplos
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)


        {
            // TODO: esta linha de código carrega dados na tabela 'bd_crudDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bd_crudDataSet.produto);
            ProdutoListDataGrid.DataSource = GetProdutoList(); //daqui para baixo é a conexao com o BD atravez do Visual Studio;
        }

        private DataTable GetProdutoList()
        {
            
                DataTable dtProdutos = new DataTable();


                string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection("server=localhost;port=3306;User Id=administrador;database=bd_crud;password=masterkey2020")) 
                {
                    using (MySqlCommand cmd = new MySqlCommand("Select * from produto", con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();

                        dtProdutos.Load(reader);
                    }
                }
                return dtProdutos;

            }
      
            }
        }
 
