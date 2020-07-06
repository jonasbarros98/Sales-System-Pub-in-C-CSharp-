namespace CrudExemplos
{
    partial class ConsultarEstoque
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
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnAlterarEstoque = new System.Windows.Forms.Button();
            this.txtAlterar = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblSelecionaProduto = new System.Windows.Forms.Label();
            this.btnDesistir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDados
            // 
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(12, 61);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.Size = new System.Drawing.Size(643, 411);
            this.dgDados.TabIndex = 0;
            this.dgDados.Click += new System.EventHandler(this.dgDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PESQUISAR:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(90, 37);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(262, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnAlterarEstoque
            // 
            this.btnAlterarEstoque.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAlterarEstoque.Location = new System.Drawing.Point(374, 478);
            this.btnAlterarEstoque.Name = "btnAlterarEstoque";
            this.btnAlterarEstoque.Size = new System.Drawing.Size(87, 29);
            this.btnAlterarEstoque.TabIndex = 3;
            this.btnAlterarEstoque.Text = "Alterar Estoque";
            this.btnAlterarEstoque.UseVisualStyleBackColor = true;
            this.btnAlterarEstoque.Click += new System.EventHandler(this.btnAlterarEstoque_Click);
            // 
            // txtAlterar
            // 
            this.txtAlterar.Location = new System.Drawing.Point(564, 38);
            this.txtAlterar.Name = "txtAlterar";
            this.txtAlterar.ReadOnly = true;
            this.txtAlterar.Size = new System.Drawing.Size(87, 20);
            this.txtAlterar.TabIndex = 5;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(469, 478);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(87, 29);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(448, 41);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(114, 13);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "NOVA QUANTIDADE:";
            // 
            // lblSelecionaProduto
            // 
            this.lblSelecionaProduto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSelecionaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionaProduto.ForeColor = System.Drawing.Color.Blue;
            this.lblSelecionaProduto.Location = new System.Drawing.Point(602, 0);
            this.lblSelecionaProduto.Name = "lblSelecionaProduto";
            this.lblSelecionaProduto.Size = new System.Drawing.Size(63, 18);
            this.lblSelecionaProduto.TabIndex = 8;
            this.lblSelecionaProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDesistir
            // 
            this.btnDesistir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDesistir.Enabled = false;
            this.btnDesistir.Location = new System.Drawing.Point(564, 478);
            this.btnDesistir.Name = "btnDesistir";
            this.btnDesistir.Size = new System.Drawing.Size(87, 29);
            this.btnDesistir.TabIndex = 9;
            this.btnDesistir.Text = "Desistir";
            this.btnDesistir.UseVisualStyleBackColor = true;
            this.btnDesistir.Click += new System.EventHandler(this.btnDesistir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Produto Selecionado:";
            // 
            // ConsultarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDesistir);
            this.Controls.Add(this.lblSelecionaProduto);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtAlterar);
            this.Controls.Add(this.btnAlterarEstoque);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "ConsultarEstoque";
            this.Text = "ConsultarEstoque";
            this.Load += new System.EventHandler(this.ConsultarEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnAlterarEstoque;
        private System.Windows.Forms.TextBox txtAlterar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblQuantidade;
        public System.Windows.Forms.Label lblSelecionaProduto;
        private System.Windows.Forms.Button btnDesistir;
        private System.Windows.Forms.Label label2;
    }
}