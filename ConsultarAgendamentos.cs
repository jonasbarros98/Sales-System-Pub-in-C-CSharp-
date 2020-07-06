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
    public partial class ConsultarAgendamentos : Form
    {
        public ConsultarAgendamentos()
        {
            InitializeComponent();
        }

        private void ConsultarAgendamentos_Load(object sender, EventArgs e)
        {
            AgendamentoController agendamentoController = new AgendamentoController();
            dgDados.DataSource = agendamentoController.ListarAgendamento();

            cmbFuncionario.Items.Add("ADM");
            cmbFuncionario.Items.Add("JEFERSON");

            cmbStatus.Items.Add("Marcado");
            cmbStatus.Items.Add("Cancelado");

        }
        private void Pesquisar(AgendamentoModel agendamento)
        {
            agendamento.Funcionario = cmbFuncionario.Text.Trim();
            agendamento.Status = cmbStatus.Text.Trim();
            agendamento.Data = dtData.Text.Trim();

            AgendamentoController agendamentoController = new AgendamentoController();
            dgDados.DataSource = agendamentoController.Pesquisar(agendamento);     
        }

        private void Filtrar()
        {
            if (cmbFuncionario.Text == "" && cmbStatus.Text == "" && dtData.Text == "")
            {
                AgendamentoController agendamentoController = new AgendamentoController();
                dgDados.DataSource = agendamentoController.ListarAgendamento();
            }
            else
            {
                AgendamentoModel agendamentoModel = new AgendamentoModel();
                Pesquisar(agendamentoModel);
            }
        }

        private void cmbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dtData_ValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void dgDados_Click(object sender, EventArgs e)
        {
            txtID.Text = dgDados.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
