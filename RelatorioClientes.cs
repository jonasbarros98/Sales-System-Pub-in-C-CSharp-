using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudExemplos
{
    public partial class RelatorioClientes : Form
    {
        public RelatorioClientes()
        {
            InitializeComponent();
        }

        private void RelatorioClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_crudDataSetClientes.dados'. Você pode movê-la ou removê-la conforme necessário.
            this.dadosTableAdapter1.Fill(this.bd_crudDataSetClientes.dados);
            // TODO: esta linha de código carrega dados na tabela 'bd_crudDataSetClientes.dados'. Você pode movê-la ou removê-la conforme necessário.
           // this.dadosTableAdapter.Fill(this.bd_crudDataSetClientes.dados);

            this.reportViewer1.RefreshReport();
        }
    }
}
