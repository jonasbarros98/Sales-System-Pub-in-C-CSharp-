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
using CrudExemplos.Controller;
using CrudExemplos.Model;


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
        private void Pesquisar(ProdutoModel produto)
        {
            produto.Nome = txtPesquisar.Text.Trim();

            ProdutoController produtoController = new ProdutoController();

            dgDados.DataSource = produtoController.Pesquisar(produto);
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            ProdutoController produtoController = new ProdutoController();
            dgDados.DataSource = produtoController.ListarProd();
        }

        /*public void RefreshGrid()
        {
            this.ProdutoListDataGrid.Refresh();
        }*/
        /*private DataTable GetProdutoList() //jeito antigo de listar os produtos.
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
                con.Close();
                
            }
                return dtProdutos;


           
        }*/

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
        

       private void ProdutoListDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }
        

        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProdutoListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NovoProduto novoProduto = new NovoProduto("");
            novoProduto.Show();
        }
         

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void ProdutoListDataGrid_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                ProdutoController produtoController = new ProdutoController();
                dgDados.DataSource = produtoController.ListarProd();
            }
            else
            {
                ProdutoModel produtoModel = new ProdutoModel();
                Pesquisar(produtoModel);
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            NovoProduto novoProduto = new NovoProduto("");
            novoProduto.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            NovoProduto novoProduto = new NovoProduto(txtCodProd.Text) ;
            novoProduto.Show();

        }

        private void dgDados_Click(object sender, EventArgs e)
        {
            txtCodProd.Text = dgDados.CurrentRow.Cells[0].Value.ToString();
        }
    }
        
}
 
