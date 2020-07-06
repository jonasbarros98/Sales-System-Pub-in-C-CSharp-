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
using CrudExemplos.Controller;
using CrudExemplos.Model;

namespace CrudExemplos
{
    public partial class TelaMenu : Form
    {
        DateTime data_hora;
        string DataEntradas = DateTime.Today.ToString("yyyy-MM-dd");
        int SaidasDia = 0;
        int EntradasDia = 0;
        public TelaMenu(string usuarioLogado = "")
        {
            InitializeComponent();
           
            txtUsuarioLogado.Text = usuarioLogado;
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void EntradasDiarias()
        {
            try
            {
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para selecionar
                MySqlCommand objComando = new MySqlCommand("select sum(Total) from caixafrente where DataVenda = '"+DataEntradas+"';", objconex);
                objComando.Parameters.Clear();
                //objComando.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtCod.Text;
                //executa o comando
                objComando.CommandType = CommandType.Text;
                //recebe o conteudo que vem do banco
                MySqlDataReader dr;
                dr = objComando.ExecuteReader();
                //insere as informações recebidas do banco para os componentes do form
                dr.Read();
                txtEntradas.Text = dr.IsDBNull(0) ? null : dr.GetString(0);

                if (txtEntradas.Text == "")
                {
                    txtEntradas.Text = "0";
                }


                objconex.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao buscar Saldos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void SaidasDiarias()
        {
            try
            {
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para selecionar
                MySqlCommand objComando = new MySqlCommand("select sum(ValorServico) from agendamentos where Data = '" + DataEntradas + "' and ValorServico < 0;", objconex);
                objComando.Parameters.Clear();
                //objComando.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtCod.Text;
                //executa o comando
                objComando.CommandType = CommandType.Text;
                //recebe o conteudo que vem do banco
                MySqlDataReader dr;
                dr = objComando.ExecuteReader();
                //insere as informações recebidas do banco para os componentes do form
                dr.Read();
                txtSaidas.Text = dr.IsDBNull(0) ? null : dr.GetString(0);
                if (txtSaidas.Text == "")
                {
                    SaidasDia = 0;
                    txtSaidas.Text = SaidasDia.ToString();

                }

                objconex.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao buscar Saldos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void SaldoDiario()
        {

        }

        private void TelaMenu_Load (object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_crudDataSet11.dados'. Você pode movê-la ou removê-la conforme necessário.
            //this.dadosTableAdapter.Fill(this.bd_crudDataSet11.dados);
            EntradasDiarias();
            SaidasDiarias();
            

            PessoaController pessoaController = new PessoaController();
            dgDadosAniversario.DataSource = pessoaController.ListarAniversario();


        }

     
        private void TelaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is Login)
                    {
                        formAberto.Close();
                        break;
                    }
                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            labelDataHora.Text = "Data: "+data_hora.ToLongDateString()+" Hora: "+data_hora.ToLongTimeString();

        }

        private void txtUsuarioLogado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           // CadastroParceiro Parceiro = new CadastroParceiro();
             // Parceiro.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
          //  Usuario usu = new Usuario();
          //  usu.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           // Produtos prod = new Produtos();
           // prod.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
          //  Fornecedor forn = new Fornecedor();
           // forn.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Pedido ped = new Pedido();
            //ped.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Caixa caixa = new Caixa();
            //caixa.Show();
        }

        private void abrirFecharCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void pedidoNoCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido ped = new Pedido();
            ped.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroParceiro Parceiro = new CadastroParceiro();
            Parceiro.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();
            prod.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            forn.Show();
        }

        private void clienteTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Esse formulario vai usar o conceito de MDI
            FrmClienteSelecionar frmClienteSelecionar = new FrmClienteSelecionar();
            //frmClienteSelecionar.MdiParent = this;
            frmClienteSelecionar.Show();
            
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoProduto novoProduto = new NovoProduto("");
            novoProduto.Show();
        }

        private void editarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoProduto novoProduto = new NovoProduto("");
            novoProduto.Show();
        }

        private void consultarEstoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarEstoque consultarEstoque = new ConsultarEstoque();
            consultarEstoque.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frenteDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCliente caixaFrente = new txtCliente(txtUsuarioLogado.Text);
            caixaFrente.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Agendamentos agendamentos = new Agendamentos();
            agendamentos.Show();
        }

        private void monthCalendar1_Enter(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            Agendamentos agendamentos = new Agendamentos();
            agendamentos.Show();
        }

        private void consultarAgendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAgendamentos consultarAgendamentos = new ConsultarAgendamentos();
            consultarAgendamentos.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EntradasDiarias();
            SaidasDiarias();
        }

        private void históricoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamentos agendamentos = new Agendamentos();
            agendamentos.Show();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioClientes relatorioClientes = new RelatorioClientes();
            relatorioClientes.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaProdutos categoriaProdutos = new CategoriaProdutos();
            categoriaProdutos.Show();
        }

        private void cartãoComboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartaoCombo cartaoCombo = new CartaoCombo();
            cartaoCombo.Show();
        }

        private void dgDadosAniversario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
