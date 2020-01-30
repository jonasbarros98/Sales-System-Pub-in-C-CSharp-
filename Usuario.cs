using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //puxando o conteudo da dll mysql.data p/ o projeto

namespace CrudExemplos
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //MessageBox.Show("Conectado com Sucesso");

                //inserir dados
                MySqlCommand objComando = new MySqlCommand("insert into usuarios (cod_usu, nome, estado, cidade, endereco,data_nasc,telefone,celular,cpf_cnpj,rg_ie,referencia,bairro,numero,cep,login,senha,tipo_usu) values (null,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", objconex);
                //parametros de comando sql
                objComando.Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = txtNomeUsu.Text;
                objComando.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cmbEstado.SelectedItem.ToString();
                objComando.Parameters.Add("@cidade", MySqlDbType.VarChar, 30).Value = cmbCidade.SelectedItem.ToString();
                objComando.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
                objComando.Parameters.Add("@data_nasc", MySqlDbType.VarChar, 20).Value = maskDataNascUsu.Text;
                objComando.Parameters.Add("@telefone", MySqlDbType.VarChar, 30).Value = txtTelefoneUsu.Text;
                objComando.Parameters.Add("@celular", MySqlDbType.VarChar, 30).Value = txtCelularUsu.Text;
                objComando.Parameters.Add("@cpf_cnpj", MySqlDbType.VarChar, 30).Value = txtCpfCnpjUsu.Text;
                objComando.Parameters.Add("@rg_ie", MySqlDbType.VarChar, 30).Value = txtRGIEUsu.Text;
                objComando.Parameters.Add("@referencia", MySqlDbType.VarChar, 50).Value = txtRerefencia.Text;
                objComando.Parameters.Add("@bairro", MySqlDbType.VarChar, 30).Value = txtBairro.Text;
                objComando.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNum.Text;
                objComando.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = txtCep.Text;
                objComando.Parameters.Add("@login", MySqlDbType.VarChar, 45).Value = txtLogin.Text;
                objComando.Parameters.Add("@senha", MySqlDbType.VarChar, 45).Value = txtSenha.Text;
                objComando.Parameters.Add("@tipo_usu", MySqlDbType.VarChar, 30).Value = cmbTipoUsu.SelectedItem.ToString();

                //comando para executar query
                objComando.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso!");

                //fecha conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não conectou: " + erro);

            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            //inserindo dados no combobox do estado
            cmbEstado.Items.Add("SP");
            cmbEstado.Items.Add("GO");
            cmbEstado.Items.Add("MA");
            cmbEstado.Items.Add("PA");
            cmbEstado.Items.Add("MT");
            cmbEstado.Items.Add("RS");
            cmbEstado.Items.Add("BA");
            cmbEstado.Items.Add("MG");

            //INSERINDO dados no combobox cidade
            cmbCidade.Items.Add("Rio Verde");
            cmbCidade.Items.Add("Ipora");
            cmbCidade.Items.Add("Rio de Janeiro");
            cmbCidade.Items.Add("Goiânia");
            cmbCidade.Items.Add("Santa Helena");

            //Inserindo dados no combobox Tipo de Usuario
            cmbTipoUsu.Items.Add("FUNCIONARIO");
            cmbTipoUsu.Items.Add("ADM");
            cmbTipoUsu.Items.Add("USUÁRIO");
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para deletar
                MySqlCommand objComando = new MySqlCommand("delete from usuarios where cod_usu = ?", objconex);
                objComando.Parameters.Clear();

                //buscando o parametro para deletar
                objComando.Parameters.Add("@cod_usu", MySqlDbType.Int32).Value = txtCodUsu.Text;

                // tipo de comando sendo executado
                objComando.CommandType = CommandType.Text;

                //executar o sql
                objComando.ExecuteNonQuery();

                MessageBox.Show("Registro excluído com sucesso!");

                objconex.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível deletar!\n " + erro);
                MessageBox.Show("Coloque o registro a ser removido no campo Código");
            }
        }
    }
    
}
