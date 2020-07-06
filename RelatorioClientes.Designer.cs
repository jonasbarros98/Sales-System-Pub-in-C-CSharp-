namespace CrudExemplos
{
    partial class RelatorioClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bd_crudDataSet2 = new CrudExemplos.bd_crudDataSet2();
            this.dadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosTableAdapter = new CrudExemplos.bd_crudDataSet2TableAdapters.dadosTableAdapter();
            this.bdcrudDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dadosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dadosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bd_crudDataSetClientes = new CrudExemplos.bd_crudDataSetClientes();
            this.bdcrudDataSetClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dadosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dadosTableAdapter1 = new CrudExemplos.bd_crudDataSetClientesTableAdapters.dadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bd_crudDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcrudDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_crudDataSetClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcrudDataSetClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // bd_crudDataSet2
            // 
            this.bd_crudDataSet2.DataSetName = "bd_crudDataSet2";
            this.bd_crudDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosBindingSource
            // 
            this.dadosBindingSource.DataMember = "dados";
            this.dadosBindingSource.DataSource = this.bd_crudDataSet2;
            // 
            // dadosTableAdapter
            // 
            this.dadosTableAdapter.ClearBeforeFill = true;
            // 
            // bdcrudDataSet2BindingSource
            // 
            this.bdcrudDataSet2BindingSource.DataSource = this.bd_crudDataSet2;
            this.bdcrudDataSet2BindingSource.Position = 0;
            // 
            // dadosBindingSource1
            // 
            this.dadosBindingSource1.DataMember = "dados";
            this.dadosBindingSource1.DataSource = this.bdcrudDataSet2BindingSource;
            // 
            // dadosBindingSource2
            // 
            this.dadosBindingSource2.DataMember = "dados";
            this.dadosBindingSource2.DataSource = this.bd_crudDataSet2;
            // 
            // dadosBindingSource3
            // 
            this.dadosBindingSource3.DataMember = "dados";
            this.dadosBindingSource3.DataSource = this.bdcrudDataSet2BindingSource;
            // 
            // bd_crudDataSetClientes
            // 
            this.bd_crudDataSetClientes.DataSetName = "bd_crudDataSetClientes";
            this.bd_crudDataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdcrudDataSetClientesBindingSource
            // 
            this.bdcrudDataSetClientesBindingSource.DataSource = this.bd_crudDataSetClientes;
            this.bdcrudDataSetClientesBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1Clientes";
            reportDataSource1.Value = this.dadosBindingSource4;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CrudExemplos.Relatórios.RelatorioCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(628, 464);
            this.reportViewer1.TabIndex = 0;
            // 
            // dadosBindingSource4
            // 
            this.dadosBindingSource4.DataMember = "dados";
            this.dadosBindingSource4.DataSource = this.bd_crudDataSetClientes;
            // 
            // dadosTableAdapter1
            // 
            this.dadosTableAdapter1.ClearBeforeFill = true;
            // 
            // RelatorioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 464);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioClientes";
            this.Text = "Relatorio de Clientes";
            this.Load += new System.EventHandler(this.RelatorioClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_crudDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcrudDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_crudDataSetClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcrudDataSetClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dadosBindingSource;
        private bd_crudDataSet2 bd_crudDataSet2;
        private bd_crudDataSet2TableAdapters.dadosTableAdapter dadosTableAdapter;
        private System.Windows.Forms.BindingSource dadosBindingSource1;
        private System.Windows.Forms.BindingSource bdcrudDataSet2BindingSource;
        private System.Windows.Forms.BindingSource dadosBindingSource2;
        private System.Windows.Forms.BindingSource dadosBindingSource3;
        private bd_crudDataSetClientes bd_crudDataSetClientes;
        private System.Windows.Forms.BindingSource bdcrudDataSetClientesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dadosBindingSource4;
        private bd_crudDataSetClientesTableAdapters.dadosTableAdapter dadosTableAdapter1;
    }
}