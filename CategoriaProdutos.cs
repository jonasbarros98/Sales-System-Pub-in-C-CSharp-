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
    public partial class CategoriaProdutos : Form
    {
        public CategoriaProdutos()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtCodCategoria.Text == "")
            {
               if(MessageBox.Show("Confirma inclusão de um novo registro?", "CONFIRMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtDescricao.ReadOnly = false;
                    btnGravar.Enabled = true;
                    txtDescricao.Focus();
                }
            }
            else if(e.KeyChar == 13)
            {
                try
                {
                    MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                    objconex.Open();

                    //comando sql para selecionar
                    MySqlCommand objComando = new MySqlCommand("select descricao from categoria_produto where cod_categoria = ?;", objconex);
                    objComando.Parameters.Clear();
                    objComando.Parameters.Add("@cod_categoria", MySqlDbType.Int32).Value = txtCodCategoria.Text;
                    //executa o comando
                    objComando.CommandType = CommandType.Text;
                    //recebe o conteudo que vem do banco
                    MySqlDataReader dr;
                    dr = objComando.ExecuteReader();
                    //insere as informações recebidas do banco para os componentes do form
                    dr.Read();
                    txtDescricao.Text = dr.IsDBNull(0) ? null : dr.GetString(0);
                  
                    objconex.Close();
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Categoria não encontrada com código informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //MessageBox.Show("Parceiro não encontrado com o código informado!");
                }

            }
            
        }

        private void CategoriaProdutos_Load(object sender, EventArgs e)
        {
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //MessageBox.Show("Conectado com Sucesso");

                //inserir dados
                MySqlCommand objComando = new MySqlCommand("insert into categoria_produto (cod_categoria,descricao) values (null, ?)", objconex);
                
                //parametros de comando sql
                objComando.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;
                

                if (txtDescricao.Text == "")
                {
                    MessageBox.Show("Informe os dados Obrigatórios!", "Atenção!", MessageBoxButtons.OK);

                }
                else if (MessageBox.Show("Deseja Realmente Salvar o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro gravado com sucesso!");
                    txtDescricao.Clear();
                    txtCodCategoria.Focus();
                    btnGravar.Enabled = false;
                    txtDescricao.ReadOnly = true;

                    MySqlCommand objComandoSelect = new MySqlCommand("select max(cod_categoria) from categoria_produto;", objconex);
                    objComandoSelect.Parameters.Clear();
                    objComandoSelect.Parameters.Add("@cod_categoria", MySqlDbType.Int32).Value = txtCodCategoria.Text;
                    objComandoSelect.CommandType = CommandType.Text;
                    //recebe o conteudo que vem do banco
                    MySqlDataReader dr;
                    dr = objComandoSelect.ExecuteReader();
                    dr.Read();
                    txtCodCategoria.Text = dr.IsDBNull(0) ? null : dr.GetString(0);

                }

                //fecha conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não conectou: " + erro);

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para deletar
                MySqlCommand objComando = new MySqlCommand("delete from categoria_produto where cod_categoria = ?", objconex);
                objComando.Parameters.Clear();

                //buscando o parametro para deletar
                objComando.Parameters.Add("@cod_categoria", MySqlDbType.Int32).Value = txtCodCategoria.Text;

                // tipo de comando sendo executado
                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente excluir o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro removido com sucesso!");
                    txtCodCategoria.Clear();
                    txtDescricao.Clear();
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    
                }

                objconex.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Não foi possível deletar! " + erro);
                MessageBox.Show("Para excluir coloque o código da categoria no campo Código");
            }
        }

        private void txtCodCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
