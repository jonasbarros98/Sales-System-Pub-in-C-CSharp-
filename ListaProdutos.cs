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
    public partial class ListaProdutos : Form
    {
        public SelecionaProduto informacao { get; set; }
        public object produtoTableAdapter { get; private set; }

        public ListaProdutos()
        {
            InitializeComponent();

        }
        /*protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }//Código para fixar a tela, ninguem vai conseguir movimentar o FORM.
        */

        private void ListaProdutos_Load(object sender, EventArgs e)
        {
            ProdutoController produtoController = new ProdutoController();
            dgDados.DataSource = produtoController.ListarProd();
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
                dgDados.DataSource = produtoController.ListarProd();
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

        private void dgDados_DoubleClick(object sender, EventArgs e)
        {
            lblCod.Text = dgDados.CurrentRow.Cells[0].Value.ToString();
            //CaixaFrente caixaFrente = new CaixaFrente(codigo.ToString());
            //this.Close();*/

            //CaixaFrente caixaFrente = new CaixaFrente();

            //(caixaFrente as CaixaFrente).txtCodProduto.Text = codigo.ToString();
            

        }

        private void ListaProdutos_Enter(object sender, EventArgs e)
        {

        }

        private void btnEscolhaProd_Click(object sender, EventArgs e)
        {
            

        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {

        }

        private void lblSelecionaProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
