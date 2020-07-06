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
using CrudExemplos.Controller;
using CrudExemplos.Model;

namespace CrudExemplos
{
    public partial class txtCliente : Form
    {
        public txtCliente(string userLogado = "")
        {
            InitializeComponent();

            txtUsuarioLogado.Text = userLogado;
        }

        //variaveis globais
        string DataVenda = DateTime.Today.ToString("yyyy-MM-dd");
        DateTime data_hora;
        float acrescimo = 0;
        float desconto = 0;
        //float precototal = 0;
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
        private string strMySql;
        float TotalVenda;


        private void GerarCodigoVenda()
        {
            strMySql = "select max(idVenda) from caixafrente";

            try
            {
                con.Open();
                MySqlCommand comando = new MySqlCommand(strMySql, con);

                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    txtCodvenda.Text = "1";
                }
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    txtCodvenda.Text = ra.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void ConsultarProduto()
        {
            strMySql = "Select * from produto where cod_prod='" + txtCodProduto.Text + "'";
            MySqlCommand comando = new MySqlCommand(strMySql, con);

            try
            {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
               

                if (!dr.HasRows)
                {
                    MessageBox.Show("PRODUTO NÃO ENCONTRADO! EFETUE O CADASTRO!", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodProduto.Clear();
                    txtCodProduto.Focus();
                }
                else
                {
                    txtNome.Text = dr["nome"].ToString();
                    int quantidade = int.Parse(dr["quantidade"].ToString());
                    txtPreco.Text = dr["preco_venda"].ToString();
                    txtQuantidade.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void GravarVenda()
        {
            strMySql = "insert into caixafrente(idVenda,Total,Funcionario, Usuario, Cliente, Observacoes, DataVenda,idCliente) values (@idVenda, @Total,@Funcionario,@Usuario,@Cliente,@Observacoes,@DataVenda,@idCliente)";
            MySqlCommand comando = new MySqlCommand(strMySql, con);

            comando.Parameters.AddWithValue("@idVenda", Convert.ToInt32(txtCodvenda.Text));
            comando.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtTotal2.Text));
            comando.Parameters.AddWithValue("@Funcionario", cmbBarbeiro.Text);
            comando.Parameters.AddWithValue("@Usuario", txtUsuarioLogado.Text);
            comando.Parameters.AddWithValue("@Cliente", txtNomeCliente.Text);
            comando.Parameters.AddWithValue("@Observacoes", txtObs.Text);
            comando.Parameters.AddWithValue("@DataVenda", DataVenda.ToString());
            comando.Parameters.AddWithValue("@idCliente", Convert.ToInt32(txtClient.Text));
            try
            {
                con.Open();
                comando.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                inserir();
                ProdutoListDataGrid.Rows.Clear();
                TotalVenda = 0;
                txtTotal2.Text = "0";
                txtCodProduto.Focus();
                con.Close();
            }

        }

        private void inserir()
        {
            strMySql = "insert into produtosvendidos(idProdutosVendidos, idvenda, NomeProduto, Quantidade, Total, ValorUnitario, DataVenda, Descontos, Acrescimos) values (@idProdutosVendidos,@idvenda,@NomeProduto,@Quantidade,@Total,@ValorUnitario,@DataVenda,@Descontos,@Acrescimos)";
            MySqlCommand comando = new MySqlCommand(strMySql, con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                for (int i = 0; i < ProdutoListDataGrid.Rows.Count - 1; i++)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@idvenda", txtCodvenda.Text);
                    comando.Parameters.AddWithValue("@NomeProduto", ProdutoListDataGrid.Rows[i].Cells[1].Value);
                    comando.Parameters.AddWithValue("@idProdutosVendidos", ProdutoListDataGrid.Rows[i].Cells[0].Value);
                    comando.Parameters.AddWithValue("@Quantidade", ProdutoListDataGrid.Rows[i].Cells[3].Value);
                    comando.Parameters.AddWithValue("@ValorUnitario", float.Parse(ProdutoListDataGrid.Rows[i].Cells[2].Value.ToString()));
                    comando.Parameters.AddWithValue("@Total", float.Parse(ProdutoListDataGrid.Rows[i].Cells[4].Value.ToString()));
                    comando.Parameters.AddWithValue("@DataVenda", DataVenda.ToString());
                    comando.Parameters.AddWithValue("@Descontos", float.Parse(ProdutoListDataGrid.Rows[i].Cells[5].Value.ToString()));
                    comando.Parameters.AddWithValue("@Acrescimos", float.Parse(ProdutoListDataGrid.Rows[i].Cells[6].Value.ToString()));

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void Limpar()
        {
            txtCodProduto.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtTotal1.Clear();
            txtObs.Clear();
            txtDesc.Text = desconto.ToString();
            txtAcresc.Text = acrescimo.ToString();
        }

        private void NomearDataGrid()
        {
            ProdutoListDataGrid.ColumnCount = 7;
            ProdutoListDataGrid.Columns[0].Name = "Código";
            ProdutoListDataGrid.Columns[1].Name = "Produto";
            ProdutoListDataGrid.Columns[1].Width = 267;
            ProdutoListDataGrid.Columns[2].Name = "Valor Unitário";
            ProdutoListDataGrid.Columns[3].Name = "Quantidade";
            ProdutoListDataGrid.Columns[4].Name = "Total dos Produtos";
            ProdutoListDataGrid.Columns[5].Name = "Descontos";
            ProdutoListDataGrid.Columns[6].Name = "Acréscimos";
        }

        private void ProdutoListDataGrid_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

        }

        private void InicializacaoVariaveis()
        {
            txtDesc.Text = desconto.ToString();
            txtAcresc.Text = acrescimo.ToString();
            txtClient.Text = "57";
            txtNomeCliente.Text = "CONSUMIDOR FINAL";
        }
        private void MostraFuncionarios()
        {
            MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
            objconex.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = objconex;
            com.CommandText = "select nome from usuarios where tipo_usu like '%BARBEIRO%'";
            MySqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbBarbeiro.DisplayMember = "nome";
            cmbBarbeiro.DataSource = dt;
            objconex.Close();
            cmbBarbeiro.Text = "";
        }

        private void CaixaFrente_Load(object sender, EventArgs e)
        {
            InicializacaoVariaveis();
            MostraFuncionarios();
            GerarCodigoVenda();
            NomearDataGrid();
       
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCodProduto_Validating(object sender, CancelEventArgs e)
        {
            if(txtCodProduto.Text != string.Empty)
            {
                ConsultarProduto();
            }
            else
            {
                txtCodProduto.Focus();
            }
        }

        private void txtQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if(txtQuantidade.Text != string.Empty && txtCodProduto.Text != string.Empty)
            {
                txtTotal1.Text = (float.Parse(txtPreco.Text) * float.Parse(txtQuantidade.Text)).ToString();
                AdicionarProd.Focus();
            }
            else if(txtCodProduto.Text == string.Empty)
            {
                MessageBox.Show("DIGITE O CÓDIGO DO PRODUTO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("DIGITE A QUANTIDADE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //txtQuantidade.Focus();
            }
        }

        private void BaixaEstoque()
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //comando sql para atualizar
                

                //objComando.Parameters.Add("@cod_prod", MySqlDbType.Int32).Value = txtCodProduto.Text;
                //objComando.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = txtQuantidade.Text;

                for (int i = 0; i < ProdutoListDataGrid.Rows.Count - 1; i++)
                {
                    MySqlCommand objComando = new MySqlCommand("update produto set quantidade = quantidade - @quantidade where cod_prod = @cod_prod", objconex);
                    objComando.Parameters.Clear();

                    objComando.Parameters.AddWithValue("@cod_prod", ProdutoListDataGrid.Rows[i].Cells[0].Value);
                    objComando.Parameters.AddWithValue("@quantidade", ProdutoListDataGrid.Rows[i].Cells[3].Value);
                    
                    objComando.CommandType = CommandType.Text;

                    objComando.ExecuteNonQuery();

                }

                    //objComando.ExecuteNonQuery();

                //fechar conexao
                objconex.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao atualizar" +
                    "Os campos Nome, Preço de Custo e Preço de venda não podem ficar vazios!");
            }
        }

        private void AdicionarProd_Click(object sender, EventArgs e)
        {
            if (txtTotal1.Text != string.Empty)
            {
                ProdutoListDataGrid.Rows.Add(txtCodProduto.Text, txtNome.Text, txtPreco.Text, txtQuantidade.Text, txtTotal1.Text, txtDesc.Text, txtAcresc.Text);
                TotalVenda += ((float.Parse(txtTotal1.Text) - (float.Parse(txtDesc.Text))) + float.Parse(txtAcresc.Text));
                txtTotal2.Text = TotalVenda.ToString();

                Limpar();
                btnGravarVenda.Enabled = true;
                
            }
            else if (txtQuantidade.Text == string.Empty && txtCodProduto.Text == string.Empty)
            {
                MessageBox.Show("NÃO GRAVE O PRODUTO SEM INFORMAR CÓDIGO E QUANTIDADE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else
            {
                MessageBox.Show("DIGITE OS DADOS DO PRODUTO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodProduto.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar a venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                BaixaEstoque();
                GravarVenda();
                GerarCodigoVenda();
               
                MessageBox.Show("Venda gravada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializacaoVariaveis();
                btnGravarVenda.Enabled = false;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            data_hora = DateTime.Now;
            label12.Text = "Data: " + data_hora.ToLongDateString() + " Hora: " + data_hora.ToLongTimeString();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            label12.Text = "Data: " + data_hora.ToLongDateString() + " Hora: " + data_hora.ToLongTimeString();

        }

        private void txtCodvenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Cancelar a venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                
                //this.Close();
                ProdutoListDataGrid.Rows.Clear();
                Limpar();
                txtTotal2.Text = "";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (ListaProdutos consultar = new ListaProdutos() { informacao = new SelecionaProduto() })
            {
                if (consultar.ShowDialog() == DialogResult.OK)
                    txtCodProduto.Text = consultar.lblSelecionaProduto.Text;
            }
        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBarbeiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBarbeiro.DropDownStyle = ComboBoxStyle.DropDownList; //cod. para nao permitir edição do cmbox
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
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
            using (ConsultarCliente consultar = new ConsultarCliente() { informacao = new SelecionaCliente() })
            {
                if (consultar.ShowDialog() == DialogResult.OK)
                    txtClient.Text = consultar.lblClienteSelec.Text;
                    txtNomeCliente.Text = consultar.txtNomeCliente.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           //verifica se tem alguma linha selecionada
            if(ProdutoListDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado!", "Atenção");
                return;
            }
           //exclui a linha selecionada
            else
            {
                ProdutoListDataGrid.Rows.RemoveAt(ProdutoListDataGrid.CurrentRow.Index);
            }
        }

        private void ProdutoListDataGrid_Click(object sender, EventArgs e)
        {
        }
    }
}
