using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudExemplos.Controller;
using CrudExemplos.Model;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace CrudExemplos
{
    public partial class ConsultarEstoque : Form
    {
        
        public ConsultarEstoque()
        {
            InitializeComponent();
        }

        private void ConsultarEstoque_Load(object sender, EventArgs e)
        {
            ProdutoController produtoController = new ProdutoController();
            dgDados.DataSource = produtoController.ListarEstoque();
        }

        private void Pesquisar(ProdutoModel produto)
        {
            produto.Nome = txtPesquisa.Text.Trim();

            ProdutoController produtoController = new ProdutoController();

            dgDados.DataSource = produtoController.Pesquisar(produto);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                ProdutoController produtoController = new ProdutoController();
                dgDados.DataSource = produtoController.ListarEstoque();
            }
            else
            {
                ProdutoModel produtoModel = new ProdutoModel();
                Pesquisar(produtoModel);
            }
        }

        private void dgDados_Click(object sender, EventArgs e)
        {
            lblSelecionaProduto.Text = dgDados.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAlterarEstoque_Click(object sender, EventArgs e)
        {
            txtAlterar.ReadOnly = false;
            btnGravar.Enabled = true;
            lblQuantidade.ForeColor = Color.Red;
            btnAlterarEstoque.Enabled = false;
            btnDesistir.Enabled = true;

        }

        private void btnDesistir_Click(object sender, EventArgs e)
        {
            btnAlterarEstoque.Enabled = true;
            btnGravar.Enabled = false;
            btnDesistir.Enabled = false;
            lblQuantidade.ForeColor = Color.Black;
            txtAlterar.ReadOnly = true;
            txtAlterar.Clear();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update produto set quantidade = ? where cod_prod = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = txtAlterar.Text;
                objComando.Parameters.Add("@cod_prod", MySqlDbType.Int32).Value = lblSelecionaProduto.Text;
                
                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Alterar o estoque desse produto?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    objComando.ExecuteNonQuery();

                    MessageBox.Show("Atualização realizada com sucesso!");

                    btnAlterarEstoque.Enabled = true;
                    btnGravar.Enabled = false;
                    btnDesistir.Enabled = false;
                    lblQuantidade.ForeColor = Color.Black;
                    txtAlterar.ReadOnly = true;
                    txtAlterar.Clear();

                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Produto não selecionado ou campo Nova Quantidade está Vazio!", "Falha ao Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            
        }
    }
}
