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

        public void RefreshGrid()
        {
            this.ProdutoListDataGrid.Refresh();
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
                con.Close();
                
            }
                return dtProdutos;


           
        }

        public void listar()
        {
            ProdutoListDataGrid.DataSource = GetProdutoList();
        }
        

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
        

        private void ProdutoListDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodProd.Text = ProdutoListDataGrid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = ProdutoListDataGrid.CurrentRow.Cells[1].Value.ToString();
            txtPrecoCusto.Text = ProdutoListDataGrid.CurrentRow.Cells[3].Value.ToString();
            txtCategoria.Text = ProdutoListDataGrid.CurrentRow.Cells[2].Value.ToString();
            txtPrecoVenda.Text = ProdutoListDataGrid.CurrentRow.Cells[4].Value.ToString();
            txtDescricao.Text = ProdutoListDataGrid.CurrentRow.Cells[5].Value.ToString();
            txtCodPerson.Text = ProdutoListDataGrid.CurrentRow.Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update produto set nome = ?, categoria = ?, preco_custo = ?, preco_venda = ?, descricao = ?, cod_personalizado = ? where cod_prod = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
                objComando.Parameters.Add("@categoria", MySqlDbType.VarChar, 45).Value = txtCategoria.Text;
                objComando.Parameters.Add("@preco_custo", MySqlDbType.Float).Value = txtPrecoCusto.Text;
                objComando.Parameters.Add("@preco_venda", MySqlDbType.Float).Value = txtPrecoVenda.Text;
                objComando.Parameters.Add("@descricao", MySqlDbType.VarChar, 70).Value = txtDescricao.Text;
                objComando.Parameters.Add("@cod_personalizado", MySqlDbType.VarChar, 45).Value = txtCodPerson.Text;
                objComando.Parameters.Add("@cod_prod", MySqlDbType.Int32).Value = txtCodProd.Text;


                objComando.CommandType = CommandType.Text;
                objComando.ExecuteNonQuery();
                //fechar conexao
                objconex.Close();

                MessageBox.Show("Atualização realizada com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao atualizar" +
                    " Os campos Nome, Preço de Custo e Preço de venda não podem ficar vazios!");
            }
            LimpaTexbox();
            listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("insert into produto (cod_prod , nome,categoria, preco_custo, preco_venda,descricao,cod_personalizado) values (null,?,?,?,?,?,?)", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
                objComando.Parameters.Add("@categoria", MySqlDbType.VarChar, 10).Value = txtCategoria.Text;
                objComando.Parameters.Add("@preco_custo", MySqlDbType.Float).Value = txtPrecoCusto.Text;
                objComando.Parameters.Add("@preco_venda", MySqlDbType.Float).Value = txtPrecoVenda.Text;
                objComando.Parameters.Add("@descricao", MySqlDbType.VarChar, 70).Value = txtDescricao.Text;
                objComando.Parameters.Add("@cod_personalizado", MySqlDbType.VarChar, 45).Value = txtCodPerson.Text;



                objComando.CommandType = CommandType.Text;
                objComando.ExecuteNonQuery();
                //fechar conexao
                objconex.Close();

                //MessageBox.Show("Cadastro realizado com sucesso!");
                MessageBox.Show("Cadastro realizado com sucesso!", ":: Controle de Cadastro ::", MessageBoxButtons.OK, MessageBoxIcon.Information);

               // GetProdutoList();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao salvar os dados!" +
                    " Preencha os campos obrigatórios");
            }
            LimpaTexbox();  
            listar();
            




        }
        private void LimpaTexbox()
        {
            txtNome.Text = "";
            txtCategoria.Text = "";
            txtPrecoCusto.Text = "";
            txtPrecoVenda.Text = "";
            txtDescricao.Text = "";
            txtCodPerson.Text = "";
        }

        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para deletar
                MySqlCommand objComando = new MySqlCommand("delete from produto where cod_prod = ?", objconex);
                objComando.Parameters.Clear();

                //buscando o parametro para deletar
                objComando.Parameters.Add("@cod_prod", MySqlDbType.Int32).Value = txtCodProd.Text;

                // tipo de comando sendo executado
                objComando.CommandType = CommandType.Text;

                //executar o sql
                objComando.ExecuteNonQuery();

                MessageBox.Show("Registro removido com sucesso!");

                objconex.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível deletar " + erro);
                MessageBox.Show("Coloque o registro a ser removido no campo Código");
            }
            LimpaTexbox();
            listar();
        }

        private void ProdutoListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
        
}
 
