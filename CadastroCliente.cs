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
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtEndereco.CharacterCasing = CharacterCasing.Upper;
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtSobrenome.CharacterCasing = CharacterCasing.Upper;
            txtEndereco.CharacterCasing = CharacterCasing.Upper;
            txtReferencia.CharacterCasing = CharacterCasing.Upper;


            //inserindo dados no combobox do estado
            //cmbEstado.Items.Add("SP");
            MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
            objconex.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = objconex;
            com.CommandText = "select nome from estado";
            MySqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbEstado.DisplayMember = "nome";
            cmbEstado.DataSource = dt;
            objconex.Close();
            //-----------------------------------------
            //INSERINDO dados no combobox cidade
            //cmbCidade.Items.Add("Rio Verde");
            MySqlConnection conex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
            objconex.Open();
            MySqlCommand comand = new MySqlCommand();
            comand.Connection = objconex;
            comand.CommandText = "select nome from cidade";
            MySqlDataReader dread = comand.ExecuteReader();
            DataTable dtab = new DataTable();
            dtab.Load(dread);
            cmbCidade.DisplayMember = "nome";
            cmbCidade.DataSource = dtab;




        }
        private void LimpaTexbox()
        {
            txtCod.Text = "";
            txtNome.Text = "";
            cmbEstado.Text = "";
            cmbCidade.Text = "";
            txtEndereco.Text = "";
            maskDataNasc.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtCpfCnpj.Text = "";
            txtRGIE.Text = "";
            txtReferencia.Text = "";
            txtBairro.Text = "";
            txtNum.Text = "";
            txtCep.Text = "";
            txtEmail.Text = "";
            txtSobrenome.Text = "";
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
                MySqlCommand objComando = new MySqlCommand("insert into dados (cd_dados, nm_nome, sg_estado, nm_cidade, ds_endereco,data_nascimento,tel_principal,celular,cpf_cnpj,rg_ie,tipo_tra,referencia,bairro,numero,cep,sobrenome) values (null, ?, ?, ?, ?,?,?,?,?,?,?,?,?,?,?,?)", objconex);
                //parametros de comando sql
                objComando.Parameters.Add("@nm_nome", MySqlDbType.VarChar, 60).Value = txtNome.Text;
                objComando.Parameters.Add("@sg_estado", MySqlDbType.VarChar, 30).Value = cmbEstado.Text;
                objComando.Parameters.Add("@nm_cidade", MySqlDbType.VarChar, 30).Value = cmbCidade.Text;
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
                objComando.Parameters.Add("@sobrenome", MySqlDbType.VarChar, 80).Value = txtSobrenome.Text;

                if (txtNome.Text == "" || txtCpfCnpj.Text == "" || txtTelefone.Text == "")
                {
                    MessageBox.Show("Informe os dados Obrigatórios!", "Atenção!", MessageBoxButtons.OK);
                    
                }
                else if (MessageBox.Show("Deseja Realmente Salvar o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro gravado com sucesso!");
                    LimpaTexbox();
                }
                
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
    
                if(MessageBox.Show("Deseja Realmente excluir o registro?","Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro removido com sucesso!");
                    LimpaTexbox();
                }

                objconex.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Não foi possível deletar! " + erro);
                MessageBox.Show("Para excluir coloque o código do cliente no campo COD");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para selecionar
                MySqlCommand objComando = new MySqlCommand("select nm_nome, sg_estado, nm_cidade, ds_endereco, data_nascimento, tel_principal, celular, cpf_cnpj, rg_ie, referencia, bairro, numero, cep, email, sobrenome from dados where cd_dados = ?;", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtCod.Text;
                //executa o comando
                objComando.CommandType = CommandType.Text;
                //recebe o conteudo que vem do banco
                MySqlDataReader dr;
                dr = objComando.ExecuteReader();
                //insere as informações recebidas do banco para os componentes do form
                dr.Read();
                txtNome.Text = dr.IsDBNull(0) ? null : dr.GetString(0);
                cmbEstado.Text = dr.IsDBNull(1) ? null : dr.GetString(1);
                cmbCidade.Text = dr.IsDBNull(2) ? null : dr.GetString(2);
                txtEndereco.Text = dr.IsDBNull(3) ? null : dr.GetString(3);
                maskDataNasc.Text = dr.IsDBNull(4) ? null : dr.GetString(4);
                txtTelefone.Text = dr.IsDBNull(5) ? null : dr.GetString("tel_principal");// teste usando nome do campo ao inves de indice
                txtCelular.Text = dr.IsDBNull(6) ? null : dr.GetString(6);
                txtCpfCnpj.Text = dr.IsDBNull(7) ? null : dr.GetString(7);
                txtRGIE.Text = dr.IsDBNull(8) ? null : dr.GetString(8);
                txtReferencia.Text = dr.IsDBNull(9) ? null : dr.GetString(9);
                txtBairro.Text = dr.IsDBNull(10) ? null : dr.GetString(10);
                txtNum.Text = dr.IsDBNull(11) ? null : dr.GetString(11);
                txtCep.Text = dr.IsDBNull(12) ? null : dr.GetString(12);
                txtEmail.Text = dr.IsDBNull(13) ? null : dr.GetString(13);
                txtSobrenome.Text = dr.IsDBNull(14) ? null : dr.GetString(14);

                if (txtNome.Text == null)
                {
                    txtNome.Text = "";

                }
                else if(cmbEstado.Text == null)
                {
                    cmbEstado.Text = "";
                }
                else if (cmbCidade.Text == null)
                {
                    cmbCidade.Text = "";
                }
                else if (txtEndereco.Text == null)
                {
                    txtEndereco.Text = "";
                }
                else if (maskDataNasc.Text == null)
                {
                    maskDataNasc.Text = "";
                }
                else if (txtTelefone.Text == null)
                {
                    txtTelefone.Text = "";
                }
                else if (txtCelular.Text == null)
                {
                    txtCelular.Text = "";
                }
                else if (txtCpfCnpj.Text == null)
                {
                    txtCpfCnpj.Text = "";
                }
                else if (txtRGIE.Text == null)
                {
                    txtRGIE.Text = "";
                }
                else if (txtReferencia.Text == null)
                {
                    txtReferencia.Text = "";
                }
                else if (txtBairro.Text == null)
                {
                    txtBairro.Text = "";
                }
                else if (txtNum.Text == null)
                {
                    txtNum.Text = "";
                }
                else if (txtCep.Text == null)
                {
                    txtCep.Text = "";
                }
                else if(txtEmail.Text == null)
                {
                    txtEmail.Text = "";
                }
                else if (txtSobrenome.Text == null)
                {
                    txtSobrenome.Text = "";
                }



                objconex.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Parceiro não encontrado com o código informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Parceiro não encontrado com o código informado!");
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
                MySqlCommand objComando = new MySqlCommand("update dados set nm_nome = ?,sg_estado = ?, nm_cidade = ?,ds_endereco = ?,data_nascimento = ?, tel_principal = ?, celular = ?, cpf_cnpj = ?, rg_ie = ?, referencia = ?, bairro = ?, numero = ?, cep = ?, email = ?, sobrenome = ? where cd_dados = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@nm_nome", MySqlDbType.VarChar, 60).Value = txtNome.Text;
                objComando.Parameters.Add("@sg_estado", MySqlDbType.VarChar, 2).Value = cmbEstado.Text;
                objComando.Parameters.Add("@nm_cidade", MySqlDbType.VarChar, 30).Value = cmbCidade.Text;
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
                objComando.Parameters.Add("@sobrenome", MySqlDbType.VarChar, 80).Value = txtSobrenome.Text;
                objComando.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtCod.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                    LimpaTexbox();
                }
                
                //fechar conexao
                objconex.Close();

               
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao editar! Informe o código do parceiro", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void txtCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LimpaTexbox();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList; //cod. para nao permitir edição do cmbox
        }

        private void cmbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCidade.DropDownStyle = ComboBoxStyle.DropDownList; //cod. para nao permitir edição do cmbox
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
