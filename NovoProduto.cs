using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace CrudExemplos
{
    public partial class NovoProduto : Form
    {
        public NovoProduto(string codprod)
        {
            InitializeComponent();
            txtCodProd.Text = codprod;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }


        private void LimpaTexbox()
        {
            txtNome.Text = "";
            txtCategoria.Text = "";
            txtPrecoCusto.Text = "";
            txtPrecoVenda.Text = "";
            txtDescricao.Text = "";
            txtCodPerson.Text = "";
            cmbTipo.Text = "";
            txtQuantidade.Text = "";
        }

        //  public void listar()
        // {
        //   ProdutoListDataGrid.DataSource = GetProdutoList();
        //  }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update produto set nome = ?, categoria = ?, preco_custo = ?, preco_venda = ?, descricao = ?, cod_personalizado = ?, tipo = ?, quantidade = ? where cod_prod = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
                objComando.Parameters.Add("@categoria", MySqlDbType.VarChar, 45).Value = txtCategoria.Text;
                objComando.Parameters.Add("@preco_custo", MySqlDbType.Float).Value = txtPrecoCusto.Text;
                objComando.Parameters.Add("@preco_venda", MySqlDbType.Float).Value = txtPrecoVenda.Text;
                objComando.Parameters.Add("@descricao", MySqlDbType.VarChar, 70).Value = txtDescricao.Text;
                objComando.Parameters.Add("@cod_personalizado", MySqlDbType.VarChar, 45).Value = txtCodPerson.Text;
                objComando.Parameters.Add("@cod_prod", MySqlDbType.Int32).Value = txtCodProd.Text;
                objComando.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = cmbTipo.Text;
                objComando.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = txtQuantidade.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Alterar o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    objComando.ExecuteNonQuery();
                    
                    MessageBox.Show("Atualização realizada com sucesso!");
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao atualizar" +
                    " Os campos Nome, Preço de Custo e Preço de venda não podem ficar vazios!");
            }
            LimpaTexbox();
           // listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("insert into produto (cod_prod , nome,categoria, preco_custo, preco_venda,descricao,cod_personalizado,tipo,quantidade) values (null,?,?,?,?,?,?,?,?)", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
                objComando.Parameters.Add("@categoria", MySqlDbType.VarChar, 10).Value = txtCategoria.Text;
                objComando.Parameters.Add("@preco_custo", MySqlDbType.Float).Value = txtPrecoCusto.Text;
                objComando.Parameters.Add("@preco_venda", MySqlDbType.Float).Value = txtPrecoVenda.Text;
                objComando.Parameters.Add("@descricao", MySqlDbType.VarChar, 70).Value = txtDescricao.Text;
                objComando.Parameters.Add("@cod_personalizado", MySqlDbType.VarChar, 45).Value = txtCodPerson.Text;
                objComando.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = cmbTipo.Text;
                objComando.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = txtQuantidade.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Salvar o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    objComando.ExecuteNonQuery();
                    //fechar conexao
                    objconex.Close();
                    //MessageBox.Show("Cadastro realizado com sucesso!");
                    MessageBox.Show("Cadastro realizado com sucesso!", ":: Controle de Cadastro ::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao salvar os dados!" +
                    " Preencha os campos obrigatórios");
            }
            LimpaTexbox();
          
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

                if (MessageBox.Show("Deseja Realmente excluir o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();

                    MessageBox.Show("Registro removido com sucesso!");
                }
                objconex.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Coloque o registro a ser removido no campo Código");
            }
            LimpaTexbox();
           // listar();
        }

        private void NovoProduto_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("PRODUTO");
            cmbTipo.Items.Add("SERVIÇO");
        }

        private void txtCodProd_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCodProd_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtCodProd_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCodProd_Leave(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para selecionar
                MySqlCommand objComando = new MySqlCommand("select nome,categoria,preco_custo,preco_venda,descricao,cod_personalizado,quantidade,tipo from produto where cod_prod = ?;", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@cod_prod", MySqlDbType.Int32).Value = txtCodProd.Text;
                //executa o comando
                objComando.CommandType = CommandType.Text;
                //recebe o conteudo que vem do banco
                MySqlDataReader dr;
                dr = objComando.ExecuteReader();
                //insere as informações recebidas do banco para os componentes do form
                dr.Read();
                txtNome.Text = dr.IsDBNull(0) ? null : dr.GetString("nome");
                txtCategoria.Text = dr.IsDBNull(1) ? null : dr.GetString("categoria");
                txtPrecoCusto.Text = dr.IsDBNull(2) ? null : dr.GetString("preco_custo");
                txtPrecoVenda.Text = dr.IsDBNull(3) ? null : dr.GetString("preco_venda");
                txtDescricao.Text = dr.IsDBNull(4) ? null : dr.GetString("descricao");
                txtCodPerson.Text = dr.IsDBNull(5) ? null : dr.GetString("cod_personalizado");
                txtQuantidade.Text = dr.IsDBNull(6) ? null : dr.GetString("quantidade");
                cmbTipo.Text = dr.IsDBNull(7) ? null : dr.GetString("tipo");

                if (txtNome.Text == null)
                {
                    txtNome.Text = "";

                }
                else if (txtCategoria.Text == null)
                {
                    txtCategoria.Text = "";
                }
                else if (txtPrecoCusto.Text == null)
                {
                    txtPrecoCusto.Text = "";
                }
                else if (txtPrecoVenda.Text == null)
                {
                    txtPrecoVenda.Text = "";
                }
                else if (txtDescricao.Text == null)
                {
                    txtDescricao.Text = "";
                }
                else if (txtCodPerson.Text == null)
                {
                    txtCodPerson.Text = "";
                }
                else if (txtQuantidade.Text == null)
                {
                    txtQuantidade.Text = "";
                }
                else if (cmbTipo.Text == null)
                {
                    cmbTipo.Text = "";
                }

                objconex.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Produto não encontrado com o código informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Parceiro não encontrado com o código informado!");
            }
        }
    }

}
