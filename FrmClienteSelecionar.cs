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
    public partial class FrmClienteSelecionar : Form
    {
        public object produtoTableAdapter { get; private set; }

        public FrmClienteSelecionar()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmClienteSelecionar_Load(object sender, EventArgs e)
        {
            PessoaController pessoaController = new PessoaController();
            dgDados.DataSource = pessoaController.Listar();
            RenomearColunas();

        }

        private void Pesquisar (PessoaModel pessoa)
        {
            pessoa.Nome = txtPesquisa.Text.Trim();

            PessoaController pessoaController = new PessoaController();

            dgDados.DataSource = pessoaController.Pesquisar(pessoa);
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                PessoaController pessoaController = new PessoaController();
                dgDados.DataSource = pessoaController.Listar();
            }
            else
            {
                PessoaModel pessoaModel = new PessoaModel();
                Pesquisar(pessoaModel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            CadastroParceiro cadastroParceiro = new CadastroParceiro();
            cadastroParceiro.Show();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            PessoaController pessoaController = new PessoaController();
            dgDados.DataSource = pessoaController.Listar();
        }
        private void RenomearColunas()
        {
            dgDados.Columns[0].HeaderText = "Código";
            dgDados.Columns[1].HeaderText = "Nome";
            dgDados.Columns[2].HeaderText = "UF";
            dgDados.Columns[3].HeaderText = "Cidade";
            dgDados.Columns[4].HeaderText = "Endereço";
            dgDados.Columns[5].HeaderText = "Data Nascimento";
            dgDados.Columns[6].HeaderText = "Telefone";
            dgDados.Columns[7].HeaderText = "Celular";
            dgDados.Columns[8].HeaderText = "CPF/CNPJ";
            dgDados.Columns[9].HeaderText = "RG";
            dgDados.Columns[10].HeaderText = "Tipo";
            dgDados.Columns[11].HeaderText = "Referencia";
            dgDados.Columns[12].HeaderText = "Bairro";
            dgDados.Columns[13].HeaderText = "Numero";
            dgDados.Columns[14].HeaderText = "CEP";
            dgDados.Columns[15].HeaderText = "Categoria";
            dgDados.Columns[16].HeaderText = "Email";
            dgDados.Columns[17].HeaderText = "Sobrenome";



        }

        private void dgDados_Click(object sender, EventArgs e)
        {
            txtID.Text = dgDados.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgDados.CurrentRow.Cells[1].Value.ToString();
            txtSobrenome.Text = dgDados.CurrentRow.Cells[17].Value.ToString();
            txtEndereco.Text = dgDados.CurrentRow.Cells[4].Value.ToString();
            txtCidade.Text = dgDados.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = dgDados.CurrentRow.Cells[6].Value.ToString();
            txtCpfCnpj.Text = dgDados.CurrentRow.Cells[8].Value.ToString();
            txtDataNasc.Text = dgDados.CurrentRow.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para deletar
                MySqlCommand objComando = new MySqlCommand("delete from dados where cd_dados = ?", objconex);
                objComando.Parameters.Clear();

                //buscando o parametro para deletar
                objComando.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtID.Text;

                // tipo de comando sendo executado
                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente excluir o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro removido com sucesso!");
                    //LimpaTexbox();
                    PessoaController pessoaController = new PessoaController();
                    dgDados.DataSource = pessoaController.Listar();
                }

                objconex.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Não foi possível deletar! " + erro);
                MessageBox.Show("Para excluir coloque o código do cliente no campo COD");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroParceiro cadastroParceiro = new CadastroParceiro();
            cadastroParceiro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
