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

namespace CrudExemplos
{
    public partial class TelaMenu : Form
    {
        DateTime data_hora;
        public TelaMenu()
        {
            InitializeComponent();
            Form2 usulogado = new Form2();
            txtUsuarioLogado.Text = usulogado.txtLogin.Text;

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        
        private void TelaMenu_Load (object sender, EventArgs e)
        {
            //Form2 usulogado = new Form2();
            //txtUsuarioLogado.Text = usulogado.txtuserlogado.Text;

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
                    if (formAberto is Form2)
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
            CadastroParceiro Parceiro = new CadastroParceiro();
            Parceiro.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();
            prod.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            forn.Show();
        }
    }
}
