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
    public partial class ConsultarCliente : Form
    {
        public SelecionaCliente informacao { get; set; } 
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void Pesquisar(PessoaModel pessoa)
        {
            pessoa.Nome = txtPesquisa.Text.Trim();

            PessoaController pessoaController = new PessoaController();

            dgDados.DataSource = pessoaController.Pesquisar(pessoa);
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            PessoaController pessoaController = new PessoaController();
            dgDados.DataSource = pessoaController.Listar();
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

        private void dgDados_Click(object sender, EventArgs e)
        {
            lblClienteSelec.Text = dgDados.CurrentRow.Cells[0].Value.ToString();
            txtNomeCliente.Text = dgDados.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void ConsultarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
