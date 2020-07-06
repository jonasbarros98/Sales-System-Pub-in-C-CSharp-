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
using CrudExemplos.Controller;
using CrudExemplos.Model;

namespace CrudExemplos
{
    public partial class CartaoCombo : Form
    {
        public CartaoCombo()
        {
            InitializeComponent();
        }

        private void btnAss1_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura1 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura1", MySqlDbType.Int32).Value = 1;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }

            AtualizaCartao();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        
        private void TratarAssinaturas()
        {
            #region TratandoAssinaturas
                    if (txtAss1.Text == "1")
                    {
                        txtAss1.Text = "Assinado";
                        txtAss1.BackColor = Color.Lime;
                        btnAss1.Enabled = false;
                    }
                    else
                    {
                        txtAss1.Text = "Não Assinado";
                    }
                    if (txtAss2.Text == "1")
                    {
                        txtAss2.Text = "Assinado";
                        txtAss2.BackColor = Color.Lime;
                        btnAss2.Enabled = false;
                    }
                    else
                    {
                        txtAss2.Text = "Não Assinado";
                    }
                    if (txtAss3.Text == "1")
                    {
                        txtAss3.Text = "Assinado";
                        txtAss3.BackColor = Color.Lime;
                        btnAss3.Enabled = false;
                    }
                    else
                    {
                        txtAss3.Text = "Não Assinado";
                    }
                    if (txtAss4.Text == "1")
                    {
                        txtAss4.Text = "Assinado";
                        txtAss4.BackColor = Color.Lime;
                        btnAss4.Enabled = false;
                    }
                    else
                    {
                        txtAss4.Text = "Não Assinado";
                    }
                    if (txtAss5.Text == "1")
                    {
                        txtAss5.Text = "Assinado";
                        txtAss5.BackColor = Color.Lime;
                        btnAss5.Enabled = false;
                    }
                    else
                    {
                        txtAss5.Text = "Não Assinado";
                    }
                    if (txtAss6.Text == "1")
                    {
                        txtAss6.Text = "Assinado";
                        txtAss6.BackColor = Color.Lime;
                        btnAss6.Enabled = false;
                    }
                    else
                    {
                        txtAss6.Text = "Não Assinado";
                    }
                    if (txtAss7.Text == "1")
                    {
                        txtAss7.Text = "Assinado";
                        txtAss7.BackColor = Color.Lime;
                        btnAss7.Enabled = false;
                    }
                    else
                    {
                        txtAss7.Text = "Não Assinado";
                    }
                    if (txtAss8.Text == "1")
                    {
                        txtAss8.Text = "Assinado";
                        txtAss8.BackColor = Color.Lime;
                        btnAss8.Enabled = false;
                    }
                    else
                    {
                        txtAss8.Text = "Não Assinado";
                    }
                    if (txtAss9.Text == "1")
                    {
                        txtAss9.Text = "Assinado";
                        txtAss9.BackColor = Color.Lime;
                        btnAss9.Enabled = false;
                    }
                    else
                    {
                        txtAss9.Text = "Não Assinado";
                    }
                    if (txtAss10.Text == "1")
                    {
                        txtAss10.Text = "Assinado";
                        txtAss10.BackColor = Color.Lime;
                        btnAss10.Enabled = false;
                    }
                    else
                    {
                        txtAss10.Text = "Não Assinado";
                    }
                    #endregion
                    
        }

        private void ResetarAssinaturas()
        {
            txtAss1.Text = "Não Assinado";
            txtAss1.BackColor = Color.White;
            txtAss2.Text = "Não Assinado";
            txtAss2.BackColor = Color.White;
            txtAss3.Text = "Não Assinado";
            txtAss3.BackColor = Color.White;
            txtAss4.Text = "Não Assinado";
            txtAss4.BackColor = Color.White;
            txtAss5.Text = "Não Assinado";
            txtAss5.BackColor = Color.White;
            txtAss6.Text = "Não Assinado";
            txtAss6.BackColor = Color.White;
            txtAss7.Text = "Não Assinado";
            txtAss7.BackColor = Color.White;
            txtAss8.Text = "Não Assinado";
            txtAss8.BackColor = Color.White;
            txtAss9.Text = "Não Assinado";
            txtAss9.BackColor = Color.White;
            txtAss10.Text = "Não Assinado";
            txtAss10.BackColor = Color.White;

        }

        private void CartaoCombo_Load(object sender, EventArgs e)
        {

        }
        private void AtualizaCartao()
        {
            try
            {
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para selecionar
                MySqlCommand objComando = new MySqlCommand("select Assinatura1,Assinatura2,Assinatura3,Assinatura4,Assinatura5,Assinatura6,Assinatura7,Assinatura8,Assinatura9,Assinatura10,id_cliente from cartao_combo where Cod_cartao = ?;", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;
                //executa o comando
                objComando.CommandType = CommandType.Text;
                //recebe o conteudo que vem do banco
                MySqlDataReader dr;
                dr = objComando.ExecuteReader();
                //insere as informações recebidas do banco para os componentes do form
                dr.Read();
                txtAss1.Text = dr.IsDBNull(0) ? null : dr.GetString(0);
                txtAss2.Text = dr.IsDBNull(1) ? null : dr.GetString(1);
                txtAss3.Text = dr.IsDBNull(2) ? null : dr.GetString(2);
                txtAss4.Text = dr.IsDBNull(3) ? null : dr.GetString(3);
                txtAss5.Text = dr.IsDBNull(4) ? null : dr.GetString(4);
                txtAss6.Text = dr.IsDBNull(5) ? null : dr.GetString(5);
                txtAss7.Text = dr.IsDBNull(6) ? null : dr.GetString(6);
                txtAss8.Text = dr.IsDBNull(7) ? null : dr.GetString(7);
                txtAss9.Text = dr.IsDBNull(8) ? null : dr.GetString(8);
                txtAss10.Text = dr.IsDBNull(9) ? null : dr.GetString(9);
                txtCodCliente.Text = dr.IsDBNull(10) ? null : dr.GetString(10);

                //objconex.Close();
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                gpb1.Enabled = false;

                if (txtAss1.Text == "1")
                {
                    txtAss1.Text = "Assinado";
                    txtAss1.BackColor = Color.Lime;
                    btnAss1.Enabled = false;
                }
                else
                {
                    txtAss1.Text = "Não Assinado";
                    txtAss1.BackColor = Color.White;
                    btnAss1.Enabled = true;
                }
                if (txtAss2.Text == "1")
                {
                    txtAss2.Text = "Assinado";
                    txtAss2.BackColor = Color.Lime;
                    btnAss2.Enabled = false;
                }
                else
                {
                    txtAss2.Text = "Não Assinado";
                    txtAss2.BackColor = Color.White;
                    btnAss2.Enabled = true;
                }
                if (txtAss3.Text == "1")
                {
                    txtAss3.Text = "Assinado";
                    txtAss3.BackColor = Color.Lime;
                    btnAss3.Enabled = false;
                }
                else
                {
                    txtAss3.Text = "Não Assinado";
                    txtAss3.BackColor = Color.White;
                    btnAss3.Enabled = true;
                }
                if (txtAss4.Text == "1")
                {
                    txtAss4.Text = "Assinado";
                    txtAss4.BackColor = Color.Lime;
                    btnAss4.Enabled = false;
                }
                else
                {
                    txtAss4.Text = "Não Assinado";
                    txtAss4.BackColor = Color.White;
                    btnAss4.Enabled = true;
                }
                if (txtAss5.Text == "1")
                {
                    txtAss5.Text = "Assinado";
                    txtAss5.BackColor = Color.Lime;
                    btnAss5.Enabled = false;
                }
                else
                {
                    txtAss5.Text = "Não Assinado";
                    txtAss5.BackColor = Color.White;
                    btnAss5.Enabled = true;
                }
                if (txtAss6.Text == "1")
                {
                    txtAss6.Text = "Assinado";
                    txtAss6.BackColor = Color.Lime;
                    btnAss6.Enabled = false;
                }
                else
                {
                    txtAss6.Text = "Não Assinado";
                    txtAss6.BackColor = Color.White;
                    btnAss6.Enabled = true;
                }
                if (txtAss7.Text == "1")
                {
                    txtAss7.Text = "Assinado";
                    txtAss7.BackColor = Color.Lime;
                    btnAss7.Enabled = false;
                }
                else
                {
                    txtAss7.Text = "Não Assinado";
                    txtAss7.BackColor = Color.White;
                    btnAss7.Enabled = true;
                }
                if (txtAss8.Text == "1")
                {
                    txtAss8.Text = "Assinado";
                    txtAss8.BackColor = Color.Lime;
                    btnAss8.Enabled = false;
                }
                else
                {
                    txtAss8.Text = "Não Assinado";
                    txtAss8.BackColor = Color.White;
                    btnAss8.Enabled = true;
                }
                if (txtAss9.Text == "1")
                {
                    txtAss9.Text = "Assinado";
                    txtAss9.BackColor = Color.Lime;
                    btnAss9.Enabled = false;
                }
                else
                {
                    txtAss9.Text = "Não Assinado";
                    txtAss9.BackColor = Color.White;
                    btnAss9.Enabled = true;
                }
                if (txtAss10.Text == "1")
                {
                    txtAss10.Text = "Assinado";
                    txtAss10.BackColor = Color.Lime;
                    btnAss10.Enabled = false;
                }
                else
                {
                    txtAss10.Text = "Não Assinado";
                    txtAss10.BackColor = Color.White;
                    btnAss10.Enabled = true;
                }

                dr.Close(); // fechando o primeiro MySqlDataReader, para poder abrir outra variavel do mesmo tipo e fazer 
                objconex.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Registro não encontrado com código informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Não conectou: " + erro);
            }
        }

        private void txtCodCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtCodCartao.Text == "")
            {
                if (MessageBox.Show("Confirma inclusão de um novo registro?", "CONFIRMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtCodCliente.ReadOnly = false;
                    btnGravar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    txtCodCartao.Enabled = false;
                    btnPesquisaCartao.Enabled = false;
                    txtCodCliente.Enabled = true;
                    btnPesquisaCliente.Enabled = true;
                    gpb1.Enabled = false;
                    txtCodCliente.Focus();
                    
                }
            }
            else if (e.KeyChar == 13)
            {
                try
                {
                    MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                    objconex.Open();

                    //comando sql para selecionar
                    MySqlCommand objComando = new MySqlCommand("select Assinatura1,Assinatura2,Assinatura3,Assinatura4,Assinatura5,Assinatura6,Assinatura7,Assinatura8,Assinatura9,Assinatura10,id_cliente from cartao_combo where Cod_cartao = ?;", objconex);
                    objComando.Parameters.Clear();
                    objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;
                    //executa o comando
                    objComando.CommandType = CommandType.Text;
                    //recebe o conteudo que vem do banco
                    MySqlDataReader dr;
                    dr = objComando.ExecuteReader();
                    //insere as informações recebidas do banco para os componentes do form
                    dr.Read();
                    txtAss1.Text = dr.IsDBNull(0) ? null : dr.GetString(0);
                    txtAss2.Text = dr.IsDBNull(1) ? null : dr.GetString(1);
                    txtAss3.Text = dr.IsDBNull(2) ? null : dr.GetString(2);
                    txtAss4.Text = dr.IsDBNull(3) ? null : dr.GetString(3);
                    txtAss5.Text = dr.IsDBNull(4) ? null : dr.GetString(4);
                    txtAss6.Text = dr.IsDBNull(5) ? null : dr.GetString(5);
                    txtAss7.Text = dr.IsDBNull(6) ? null : dr.GetString(6);
                    txtAss8.Text = dr.IsDBNull(7) ? null : dr.GetString(7);
                    txtAss9.Text = dr.IsDBNull(8) ? null : dr.GetString(8);
                    txtAss10.Text = dr.IsDBNull(9) ? null : dr.GetString(9);
                    txtCodCliente.Text = dr.IsDBNull(10) ? null : dr.GetString(10);

                    txtNomeCliente.ForeColor = Color.Blue;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    gpb1.Enabled = false;

                    AtualizaCartao();

                    
                    dr.Close(); // fechando o primeiro MySqlDataReader, para poder abrir outra variavel do mesmo tipo e fazer outro select

                    if (txtCodCliente.Text != String.Empty)
                    {
                        
                        MySqlCommand objComandoSelect = new MySqlCommand("select nm_nome from dados where cd_dados = ?;", objconex);
                        objComandoSelect.Parameters.Clear();
                        objComandoSelect.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtCodCliente.Text;
                        objComandoSelect.CommandType = CommandType.Text;
                        //recebe o conteudo que vem do banco
                        MySqlDataReader dra; // novo DataReader para select;
                        dra = objComandoSelect.ExecuteReader();
                        dra.Read();
                        txtNomeCliente.Text = dra.IsDBNull(0) ? null : dra.GetString(0);
                    }
                    else
                    {
                        MessageBox.Show("Informe um código válido!");
                    }

                    objconex.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Registro não encontrado com código informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gpb1.Enabled = false;
                    txtCodCliente.Clear();
                    txtNomeCliente.Clear();

                }
            }
        }

        private void btnAss3_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura3 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura3", MySqlDbType.Int32).Value = 1;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!"); 
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }

            AtualizaCartao();
        }

        private void btnAss2_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura2 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura2", MySqlDbType.Int32).Value = 1;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }

            AtualizaCartao();
        }

        private void btnAss4_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura4 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura4", MySqlDbType.Int32).Value = 1;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }

            AtualizaCartao();
        }

        private void btnAss5_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura5 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura5", MySqlDbType.Int32).Value = 1;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }

            AtualizaCartao();
        }

        private void btnAss6_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura6 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura6", MySqlDbType.Int32).Value = 1;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }

            AtualizaCartao();
        }

        private void btnAss7_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura7 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura7", MySqlDbType.Int32).Value = 1;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }

            AtualizaCartao();
        }

        private void btnAss8_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura8 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura8", MySqlDbType.Int32).Value = 1;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }

            AtualizaCartao();
        }

        private void btnAss9_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura9 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura9", MySqlDbType.Int32).Value = 1;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }

            AtualizaCartao();
        }

        private void btnAss10_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura10 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura10", MySqlDbType.Int32).Value = 1;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }
            AtualizaCartao();

            btnCorteGratis.Enabled = true;
        }

        private void btnCorteGratis_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                MySqlCommand objComando = new MySqlCommand("update cartao_combo set Assinatura1 = ?,Assinatura2 = ?,Assinatura3 = ?,Assinatura4 = ?,Assinatura5 = ?,Assinatura6 = ?,Assinatura7 = ?,Assinatura8 = ?,Assinatura9 = ?,Assinatura10 = ? where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura1", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura2", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura3", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura4", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura5", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura6", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura7", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura8", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura9", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura10", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;
                

                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente Editar este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!");
                    
                }
                //fechar conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Assinar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Não conectou: " + erro);
            }

            #region ResetarCampos
            txtAss1.BackColor = Color.White;
            txtAss1.ForeColor = Color.Black;
            txtAss1.Text = "Não Assinado";
            btnAss1.Enabled = true;

            txtAss2.BackColor = Color.White;
            txtAss2.ForeColor = Color.Black;
            txtAss2.Text = "Não Assinado";
            btnAss2.Enabled = true;

            txtAss3.BackColor = Color.White;
            txtAss3.ForeColor = Color.Black;
            txtAss3.Text = "Não Assinado";
            btnAss3.Enabled = true;

            txtAss4.BackColor = Color.White;
            txtAss4.ForeColor = Color.Black;
            txtAss4.Text = "Não Assinado";
            btnAss4.Enabled = true;

            txtAss5.BackColor = Color.White;
            txtAss5.ForeColor = Color.Black;
            txtAss5.Text = "Não Assinado";
            btnAss5.Enabled = true;

            txtAss6.BackColor = Color.White;
            txtAss6.ForeColor = Color.Black;
            txtAss6.Text = "Não Assinado";
            btnAss6.Enabled = true;

            txtAss7.BackColor = Color.White;
            txtAss7.ForeColor = Color.Black;
            txtAss7.Text = "Não Assinado";
            btnAss7.Enabled = true;

            txtAss8.BackColor = Color.White;
            txtAss8.ForeColor = Color.Black;
            txtAss8.Text = "Não Assinado";
            btnAss8.Enabled = true;

            txtAss9.BackColor = Color.White;
            txtAss9.ForeColor = Color.Black;
            txtAss9.Text = "Não Assinado";
            btnAss9.Enabled = true;

            txtAss10.BackColor = Color.White;
            txtAss10.ForeColor = Color.Black;
            txtAss10.Text = "Não Assinado";
            btnAss10.Enabled = true;

            #endregion

            btnCorteGratis.Enabled = false;
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            using (ConsultarCliente consultar = new ConsultarCliente() { informacao = new SelecionaCliente() })
            {
                if (consultar.ShowDialog() == DialogResult.OK)
                    txtCodCliente.Text = consultar.lblClienteSelec.Text;
            }
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtCodCliente.Text == "")
            {
                if (MessageBox.Show("Insira um código de cliente válido!", "CONFIRMA", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtCodCliente.Focus();
                }
            }
            else if (e.KeyChar == 13)
            {
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                if (txtCodCliente.Text != String.Empty)
                {
                    MySqlCommand objComandoSelect = new MySqlCommand("select nm_nome from dados where cd_dados = ?;", objconex);
                    objComandoSelect.Parameters.Clear();
                    objComandoSelect.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtCodCliente.Text;
                    objComandoSelect.CommandType = CommandType.Text;
                    //recebe o conteudo que vem do banco
                    MySqlDataReader dra; //DataReader para select;
                    dra = objComandoSelect.ExecuteReader();
                    dra.Read();
                    if (!dra.HasRows)
                    {
                        // txtNomeCliente.Text = dra.IsDBNull(0) ? null : dra.GetString(0);
                        MessageBox.Show("Registro não encontrado com código informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodCliente.Focus();
                    }
                    else
                    {
                        txtNomeCliente.Text = dra.IsDBNull(0) ? null : dra.GetString(0);
                        txtCodCliente.Enabled = false;
                        btnPesquisaCliente.Enabled = false;
                    }
                    dra.Close();
                    
                }
                else
                {
                    MessageBox.Show("Registro não encontrado com código informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Informe um código válido!");
                }

                objconex.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //MessageBox.Show("Conectado com Sucesso");

                //inserir dados
                MySqlCommand objComando = new MySqlCommand("insert into cartao_combo (Cod_cartao,Assinatura1 ,Assinatura2 ,Assinatura3 ,Assinatura4 ,Assinatura5 ,Assinatura6 ,Assinatura7 ,Assinatura8 ,Assinatura9 ,Assinatura10,id_cliente) values (null,?,?,?,?,?,?,?,?,?,?,?)", objconex);
                //parametros de comando sql
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Assinatura1", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura2", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura3", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura4", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura5", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura6", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura7", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura8", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura9", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@Assinatura10", MySqlDbType.Int32).Value = 0;
                objComando.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = txtCodCliente.Text;

                if (MessageBox.Show("Deseja Realmente Salvar o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro gravado com sucesso!");
                    
                    MySqlCommand objComandoSelect = new MySqlCommand("select max(Cod_cartao) from cartao_combo;", objconex);
                    objComandoSelect.Parameters.Clear();
                    objComandoSelect.CommandType = CommandType.Text;
                    //recebe o conteudo que vem do banco
                    MySqlDataReader dra; //DataReader para select;
                    dra = objComandoSelect.ExecuteReader();
                    dra.Read();
                    txtCodCartao.Text = dra.IsDBNull(0) ? null : dra.GetString(0);

                    txtCodCartao.Enabled = true;
                    txtCodCliente.Clear();
                    btnGravar.Enabled = false;
                    txtCodCartao.Focus();
                    AtualizaCartao();
                }

                //fecha conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não conectou: " + erro);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para deletar
                MySqlCommand objComando = new MySqlCommand("delete from cartao_combo where Cod_cartao = ?", objconex);
                objComando.Parameters.Clear();

                //buscando o parametro para deletar
                objComando.Parameters.Add("@Cod_cartao", MySqlDbType.Int32).Value = txtCodCartao.Text;

                // tipo de comando sendo executado
                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente excluir o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro removido com sucesso!");
                    txtCodCliente.Clear();
                    txtNomeCliente.Clear();
                    txtCodCartao.Clear();
                    txtCodCartao.Focus();
                    gpb1.Enabled = false;
                    ResetarAssinaturas();
                    btnExcluir.Enabled = false;

                }

                objconex.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Não foi possível deletar! " + erro);
                MessageBox.Show("Para excluir coloque o código do cliente no campo COD");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            gpb1.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnGravar.Enabled = false;
            btnSair.Enabled = true;
            btnGravar.Text = "Salvar";
        }
    }
}
