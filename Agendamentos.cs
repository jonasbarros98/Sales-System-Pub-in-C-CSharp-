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
    public partial class Agendamentos : Form
    {
        
        public Agendamentos()
        {
            InitializeComponent();
        }

        private void Agendamentos_Load(object sender, EventArgs e)
        {
            AgendamentoController agendamentoController = new AgendamentoController();
            dgDados.DataSource = agendamentoController.ListarAgendamento();

            cmbFuncionario.Items.Add("ADM");
            cmbFuncionario.Items.Add("JEFERSON");
            cmbServico.Items.Add("Corte");
            cmbStatus.Items.Add("Marcado");
            cmbStatus.Items.Add("Cancelado");

        }
       /* private void Pesquisar(AgendamentoModel agendamento)
        {
            agendamento.Funcionario = cmbFuncionario.Text.Trim();

            AgendamentoController agendamentoController = new AgendamentoController();
            dgDados.DataSource = agendamentoController.Pesquisar(agendamento);
        }*/

            private void LimpaTextbox()
        {
            txtCliente.Clear();
            txtValor.Clear();
            cmbFuncionario.Text = "";
            cmbServico.Text = "";
            cmbStatus.Text = "";
            txtNomeCliente.Clear();
            txtCodAgendamento.Clear();
            

        }
        private void cmbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFuncionario.Items.Add("ADM");
            cmbFuncionario.Items.Add("JEFERSON");
        }

        private void PesquisarData(AgendamentoModel agendamento)
        {
            agendamento.Data = dtData.Text.Trim();

            AgendamentoController agendamentoController = new AgendamentoController();
            dgDados.DataSource = agendamentoController.PesquisarData(agendamento);
        }

        private void Filtrar()
        {
            if (dtData.Text == "")
            {
                AgendamentoController agendamentoController = new AgendamentoController();
                dgDados.DataSource = agendamentoController.ListarAgendamento();
            }
            else
            {
                AgendamentoModel agendamentoModel = new AgendamentoModel();
                PesquisarData(agendamentoModel);
            }
        }

        private void cmbFuncionario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {           
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();
                //MessageBox.Show("Conectado com Sucesso");

                //inserir dados
                MySqlCommand objComando = new MySqlCommand("insert into agendamentos (idAgendamentos, Funcionario, Cliente, Servico, ValorServico, Data, Hora, Status,id_cliente) Values (null, ?,?,?,?,?,?,?,?)", objconex);
                //parametros de comando sql
                objComando.Parameters.Add("@Funcionario", MySqlDbType.VarChar, 60).Value = cmbFuncionario.Text;
                objComando.Parameters.Add("@Cliente", MySqlDbType.VarChar, 60).Value = txtNomeCliente.Text;
                objComando.Parameters.Add("@Servico", MySqlDbType.VarChar, 45).Value = cmbServico.Text;
                objComando.Parameters.Add("@ValorServico", MySqlDbType.Float).Value = txtValor.Text;
                objComando.Parameters.Add("@Data", MySqlDbType.Date).Value = dtData.Text;
                objComando.Parameters.Add("@Hora", MySqlDbType.VarChar,20).Value = dtHora.Text;
                objComando.Parameters.Add("@Status", MySqlDbType.VarChar, 45).Value = cmbStatus.Text;
                objComando.Parameters.Add("@id_cliente", MySqlDbType.Int32).Value = txtCliente.Text;



                if (cmbFuncionario.Text == "" || txtCliente.Text == "" || cmbServico.Text == "" || txtValor.Text == "")
                {
                    MessageBox.Show("Informe os dados Obrigatórios!", "Atenção!", MessageBoxButtons.OK);

                }
                else if (MessageBox.Show("Deseja Realmente Salvar o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro gravado com sucesso!");
                    LimpaTextbox();

                    AgendamentoController agendamentoController = new AgendamentoController();
                    dgDados.DataSource = agendamentoController.ListarAgendamento();

                }

                //fecha conexao
                objconex.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não conectou: " + erro);

            }
        }

        private void dtHora_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultarAgendamentos consultarAgendamentos = new ConsultarAgendamentos();
            consultarAgendamentos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (ConsultarCliente consultar = new ConsultarCliente() { informacao = new SelecionaCliente()})
            {
                if (consultar.ShowDialog() == DialogResult.OK)
                    txtCliente.Text = consultar.lblClienteSelec.Text;
                    txtNomeCliente.Text = consultar.txtNomeCliente.Text;
            }
        }

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgDados_Click(object sender, EventArgs e)
        {
            //txtCodAgendamento.Text = dgDados.CurrentRow.Cells[0].Value.ToString();
            if (dgDados.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Nenhum Agendamento selecionado!");
                LimpaTextbox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                //passa a string de conexao
                MySqlConnection objconex = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
                objconex.Open();

                //comando sql para deletar
                MySqlCommand objComando = new MySqlCommand("delete from agendamentos where idAgendamentos = ?", objconex);
                objComando.Parameters.Clear();

                //buscando o parametro para deletar
                objComando.Parameters.Add("@idAgendamentos", MySqlDbType.Int32).Value = txtCodAgendamento.Text;

                // tipo de comando sendo executado
                objComando.CommandType = CommandType.Text;

                if (MessageBox.Show("Deseja Realmente excluir o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //executar o sql
                    objComando.ExecuteNonQuery();
                    MessageBox.Show("Registro removido com sucesso!");
                    //LimpaTexbox();
                    AgendamentoController agendamentoController = new AgendamentoController();
                    dgDados.DataSource = agendamentoController.ListarAgendamento();

                    LimpaTextbox();
                 
                }

                objconex.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Não foi possível deletar! " + erro);
                MessageBox.Show("Para excluir clique no agendamento!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtData_ValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Agendamentos_Activated(object sender, EventArgs e)
        {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            
            txtCliente.Text = consultarCliente.lblClienteSelec.Text;
        }

        private void Agendamentos_ControlAdded(object sender, ControlEventArgs e)
        {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            //consultarCliente.Show();
            //txtCliente.Text = consultarCliente.lblClienteSelec.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dgDados_DoubleClick(object sender, EventArgs e)
        {
            if(dgDados.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Nenhum Agendamento selecionado!");
                LimpaTextbox();
            }
            else
            {
                txtCodAgendamento.Text = dgDados.CurrentRow.Cells[0].Value.ToString();
                cmbFuncionario.Text = dgDados.CurrentRow.Cells[1].Value.ToString();
                txtNomeCliente.Text = dgDados.CurrentRow.Cells[2].Value.ToString();
                cmbServico.Text = dgDados.CurrentRow.Cells[3].Value.ToString();
                txtValor.Text = dgDados.CurrentRow.Cells[4].Value.ToString();
                dtData.Text = dgDados.CurrentRow.Cells[5].Value.ToString();
                dtHora.Text = dgDados.CurrentRow.Cells[6].Value.ToString();
                cmbStatus.Text = dgDados.CurrentRow.Cells[7].Value.ToString();
                txtCliente.Text = dgDados.CurrentRow.Cells[8].Value.ToString();

            }

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
