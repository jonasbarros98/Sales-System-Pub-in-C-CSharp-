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
    public partial class CadastroParceiro : Form
    {
        public CadastroParceiro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                MySqlCommand objComando = new MySqlCommand("insert into dados (cd_dados, nm_nome, sg_estado, nm_cidade, ds_endereco,data_nascimento,tel_principal,celular,cpf_cnpj,rg_ie,tipo_tra,referencia,bairro,numero,cep) values (null, ?, ?, ?, ?,?,?,?,?,?,?,?,?,?,?)", objconex);
                //parametros de comando sql
                objComando.Parameters.Add("@nm_nome", MySqlDbType.VarChar, 60).Value = txtNome.Text;
                objComando.Parameters.Add("@sg_estado", MySqlDbType.VarChar, 2).Value = cmbEstado.SelectedItem.ToString();
                objComando.Parameters.Add("@nm_cidade", MySqlDbType.VarChar, 30).Value = cmbCidade.SelectedItem.ToString();
                objComando.Parameters.Add("@ds_endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
                objComando.Parameters.Add("@data_nascimento", MySqlDbType.VarChar,20).Value = maskDataNasc.Text;
                objComando.Parameters.Add("@tel_principal", MySqlDbType.VarChar, 30).Value = txtTelefone.Text;
                objComando.Parameters.Add("@celular", MySqlDbType.VarChar, 30).Value = txtCelular.Text;
                objComando.Parameters.Add("@cpf_cnpj", MySqlDbType.VarChar, 30).Value = txtCpfCnpj.Text;
                objComando.Parameters.Add("@rg_ie", MySqlDbType.VarChar, 30).Value = txtRGIE.Text;
                objComando.Parameters.Add("@tipo_tra", MySqlDbType.VarChar, 30).Value = "C";
                objComando.Parameters.Add("@referencia", MySqlDbType.VarChar, 50).Value = txtReferencia.Text;
                objComando.Parameters.Add("@bairro", MySqlDbType.VarChar, 30).Value = txtBairro.Text;
                objComando.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNum.Text;
                objComando.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = txtCep.Text;



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

        private void button2_Click(object sender, EventArgs e)
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
                objComando.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtCod.Text;

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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para selecionar
                MySqlCommand objComando = new MySqlCommand("select nm_nome, sg_estado, nm_cidade, ds_endereco, data_nascimento, tel_principal, celular, cpf_cnpj, rg_ie, referencia, bairro, numero, cep, email from dados where cd_dados = ?;", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtCod.Text;
                //executa o comando
                objComando.CommandType = CommandType.Text;
                //recebe o conteudo que vem do banco
                MySqlDataReader dr;
                dr = objComando.ExecuteReader();
                //insere as informações recebidas do banco para os componentes do form
                dr.Read();
                txtNome.Text = dr.GetString(0);
                cmbEstado.Text = dr.GetString(1);
                cmbCidade.Text = dr.GetString(2);
                txtEndereco.Text = dr.GetString(3);
                maskDataNasc.Text = dr.GetString(4);
                txtTelefone.Text = dr.GetString(5);
                txtCelular.Text = dr.GetString(6);
                txtCpfCnpj.Text = dr.GetString(7);
                txtRGIE.Text = dr.GetString(8);
                txtReferencia.Text = dr.GetString(9);
                txtBairro.Text = dr.GetString(10);
                txtNum.Text = dr.GetString(11);
                txtCep.Text = dr.GetString(12);
                txtEmail.Text = dr.GetString(13);

                objconex.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao buscar os dados!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update dados set nm_nome = ?,sg_estado = ?, nm_cidade = ?,ds_endereco = ?,data_nascimento = ?, tel_principal = ?, celular = ?, cpf_cnpj = ?, rg_ie = ?, referencia = ?, bairro = ?, numero = ?, cep = ?, email = ? where cd_dados = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@nm_nome", MySqlDbType.VarChar, 60).Value = txtNome.Text;
                objComando.Parameters.Add("@sg_estado", MySqlDbType.VarChar, 2).Value = cmbEstado.SelectedItem.ToString();
                objComando.Parameters.Add("@nm_cidade", MySqlDbType.VarChar, 30).Value = cmbCidade.SelectedItem.ToString();
                objComando.Parameters.Add("@ds_endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
                objComando.Parameters.Add("@data_nascimento", MySqlDbType.VarChar, 20).Value = maskDataNasc.Text;
                objComando.Parameters.Add("@tel_principal", MySqlDbType.VarChar, 30).Value = txtTelefone.Text;
                objComando.Parameters.Add("@celular", MySqlDbType.VarChar, 30).Value = txtCelular.Text;
                objComando.Parameters.Add("@cpf_cnpj", MySqlDbType.VarChar, 30).Value = txtCpfCnpj.Text;
                objComando.Parameters.Add("@rg_ie", MySqlDbType.VarChar, 30).Value = txtRGIE.Text;
                objComando.Parameters.Add("@referencia", MySqlDbType.VarChar, 50).Value = txtReferencia.Text;
                objComando.Parameters.Add("@bairro", MySqlDbType.VarChar, 30).Value = txtBairro.Text;
                objComando.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNum.Text;
                objComando.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = txtCep.Text;
                objComando.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = txtEmail.Text;
                objComando.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtCod.Text;

                objComando.CommandType = CommandType.Text;
                objComando.ExecuteNonQuery();
                //fechar conexao
                objconex.Close();

                MessageBox.Show("Atualização realizada com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao atualizar" + erro);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
