namespace CrudExemplos
{
    partial class txtCliente
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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtAcresc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.lblTotaItens = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProdutoListDataGrid = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUsuarioLogado = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodvenda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBarbeiro = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AdicionarProd = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGravarVenda = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoListDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDesc.Location = new System.Drawing.Point(702, 83);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 51;
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // txtAcresc
            // 
            this.txtAcresc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAcresc.BackColor = System.Drawing.Color.White;
            this.txtAcresc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAcresc.Location = new System.Drawing.Point(702, 28);
            this.txtAcresc.Name = "txtAcresc";
            this.txtAcresc.Size = new System.Drawing.Size(100, 20);
            this.txtAcresc.TabIndex = 50;
            this.txtAcresc.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.txtAcresc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(699, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 48;
            this.label11.Text = "-Desconto: ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(699, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "+Acréscimo:";
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPreco.BackColor = System.Drawing.Color.White;
            this.txtPreco.Enabled = false;
            this.txtPreco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPreco.Location = new System.Drawing.Point(426, 28);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 46;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button8.BackColor = System.Drawing.Color.Crimson;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(985, 547);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 38);
            this.button8.TabIndex = 45;
            this.button8.Text = "Sair";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(423, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "Preço";
            // 
            // txtTotal1
            // 
            this.txtTotal1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotal1.BackColor = System.Drawing.Color.White;
            this.txtTotal1.Enabled = false;
            this.txtTotal1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotal1.Location = new System.Drawing.Point(571, 28);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(100, 20);
            this.txtTotal1.TabIndex = 43;
            // 
            // lblTotaItens
            // 
            this.lblTotaItens.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotaItens.AutoSize = true;
            this.lblTotaItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaItens.ForeColor = System.Drawing.Color.Black;
            this.lblTotaItens.Location = new System.Drawing.Point(568, 10);
            this.lblTotaItens.Name = "lblTotaItens";
            this.lblTotaItens.Size = new System.Drawing.Size(94, 15);
            this.lblTotaItens.TabIndex = 42;
            this.lblTotaItens.Text = "Total de Itens";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(287, -46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 39;
            // 
            // ProdutoListDataGrid
            // 
            this.ProdutoListDataGrid.AllowUserToOrderColumns = true;
            this.ProdutoListDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdutoListDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProdutoListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdutoListDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProdutoListDataGrid.Location = new System.Drawing.Point(237, 125);
            this.ProdutoListDataGrid.Name = "ProdutoListDataGrid";
            this.ProdutoListDataGrid.ReadOnly = true;
            this.ProdutoListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdutoListDataGrid.Size = new System.Drawing.Size(893, 416);
            this.ProdutoListDataGrid.TabIndex = 36;
            this.ProdutoListDataGrid.Click += new System.EventHandler(this.ProdutoListDataGrid_Click);
            this.ProdutoListDataGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdutoListDataGrid_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(234, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 15);
            this.label13.TabIndex = 54;
            this.label13.Text = "Informe: Produto/Serviço";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.BackColor = System.Drawing.Color.White;
            this.txtCodProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodProduto.Location = new System.Drawing.Point(237, 28);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(111, 20);
            this.txtCodProduto.TabIndex = 55;
            this.txtCodProduto.TextChanged += new System.EventHandler(this.txtCodProduto_TextChanged);
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            this.txtCodProduto.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodProduto_Validating);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(423, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 56;
            this.label10.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQuantidade.Location = new System.Drawing.Point(426, 83);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 57;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox13_KeyPress);
            this.txtQuantidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantidade_Validating);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Enabled = false;
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(237, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 20);
            this.txtNome.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(237, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "Nome";
            // 
            // txtTotal2
            // 
            this.txtTotal2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotal2.BackColor = System.Drawing.Color.White;
            this.txtTotal2.Enabled = false;
            this.txtTotal2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotal2.Location = new System.Drawing.Point(571, 83);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(100, 20);
            this.txtTotal2.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(568, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 15);
            this.label14.TabIndex = 60;
            this.label14.Text = "Total Geral";
            // 
            // txtUsuarioLogado
            // 
            this.txtUsuarioLogado.BackColor = System.Drawing.Color.White;
            this.txtUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUsuarioLogado.Location = new System.Drawing.Point(7, 80);
            this.txtUsuarioLogado.Multiline = true;
            this.txtUsuarioLogado.Name = "txtUsuarioLogado";
            this.txtUsuarioLogado.ReadOnly = true;
            this.txtUsuarioLogado.Size = new System.Drawing.Size(221, 22);
            this.txtUsuarioLogado.TabIndex = 4;
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.White;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtObs.Location = new System.Drawing.Point(7, 349);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(221, 77);
            this.txtObs.TabIndex = 5;
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.Color.White;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtClient.Location = new System.Drawing.Point(7, 258);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(41, 22);
            this.txtClient.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(4, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Observações: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barbeiro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero da Venda: ";
            // 
            // txtCodvenda
            // 
            this.txtCodvenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodvenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodvenda.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtCodvenda.Location = new System.Drawing.Point(157, 9);
            this.txtCodvenda.Multiline = true;
            this.txtCodvenda.Name = "txtCodvenda";
            this.txtCodvenda.ReadOnly = true;
            this.txtCodvenda.Size = new System.Drawing.Size(71, 21);
            this.txtCodvenda.TabIndex = 11;
            this.txtCodvenda.TextChanged += new System.EventHandler(this.txtCodvenda_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtNomeCliente);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbBarbeiro);
            this.panel1.Controls.Add(this.txtCodvenda);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtClient);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.txtUsuarioLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 591);
            this.panel1.TabIndex = 35;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Image = global::CrudExemplos.Properties.Resources.lupa;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(49, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 22);
            this.button6.TabIndex = 65;
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(4, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Usuário Logado:";
            // 
            // cmbBarbeiro
            // 
            this.cmbBarbeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarbeiro.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbBarbeiro.FormattingEnabled = true;
            this.cmbBarbeiro.Location = new System.Drawing.Point(7, 167);
            this.cmbBarbeiro.Name = "cmbBarbeiro";
            this.cmbBarbeiro.Size = new System.Drawing.Size(221, 24);
            this.cmbBarbeiro.TabIndex = 12;
            this.cmbBarbeiro.SelectedIndexChanged += new System.EventHandler(this.cmbBarbeiro_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::CrudExemplos.Properties.Resources.ic_back_97586__1_;
            this.button2.Location = new System.Drawing.Point(100, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Voltar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(832, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 63;
            this.label12.Text = "data";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // AdicionarProd
            // 
            this.AdicionarProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdicionarProd.BackColor = System.Drawing.Color.Transparent;
            this.AdicionarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdicionarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdicionarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdicionarProd.Location = new System.Drawing.Point(944, 83);
            this.AdicionarProd.Name = "AdicionarProd";
            this.AdicionarProd.Size = new System.Drawing.Size(90, 36);
            this.AdicionarProd.TabIndex = 40;
            this.AdicionarProd.Text = "Adicionar Produto";
            this.AdicionarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AdicionarProd.UseVisualStyleBackColor = false;
            this.AdicionarProd.Click += new System.EventHandler(this.AdicionarProd_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Image = global::CrudExemplos.Properties.Resources.lupa;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(354, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 20);
            this.button5.TabIndex = 64;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::CrudExemplos.Properties.Resources._1486564706_trash_can_81531;
            this.button1.Location = new System.Drawing.Point(581, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar Venda";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGravarVenda
            // 
            this.btnGravarVenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGravarVenda.BackColor = System.Drawing.Color.Green;
            this.btnGravarVenda.Enabled = false;
            this.btnGravarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGravarVenda.Image = global::CrudExemplos.Properties.Resources.dollars_96693;
            this.btnGravarVenda.Location = new System.Drawing.Point(725, 547);
            this.btnGravarVenda.Name = "btnGravarVenda";
            this.btnGravarVenda.Size = new System.Drawing.Size(254, 38);
            this.btnGravarVenda.TabIndex = 38;
            this.btnGravarVenda.Text = "Finalizar Venda";
            this.btnGravarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravarVenda.UseVisualStyleBackColor = false;
            this.btnGravarVenda.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1040, 83);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 36);
            this.button7.TabIndex = 65;
            this.button7.Text = "Excluir Produto";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.White;
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNomeCliente.Location = new System.Drawing.Point(78, 258);
            this.txtNomeCliente.Multiline = true;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(150, 22);
            this.txtNomeCliente.TabIndex = 66;
            // 
            // txtCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 591);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtAcresc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.btnGravarVenda);
            this.Controls.Add(this.AdicionarProd);
            this.Controls.Add(this.lblTotaItens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProdutoListDataGrid);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "txtCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa Frente de Loja";
            this.Load += new System.EventHandler(this.CaixaFrente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoListDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtAcresc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.Button btnGravarVenda;
        private System.Windows.Forms.Button AdicionarProd;
        private System.Windows.Forms.Label lblTotaItens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ProdutoListDataGrid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUsuarioLogado;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodvenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.ComboBox cmbBarbeiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtNomeCliente;
    }
}