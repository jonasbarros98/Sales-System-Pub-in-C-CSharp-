namespace CrudExemplos
{
    partial class Caixa
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
            this.LabelDataHora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProdutoListDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
<<<<<<< HEAD
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.cmbBarbeiro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
=======
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
>>>>>>> c838a56767ad5ebd5085c328102739e7487b4838
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoListDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelDataHora
            // 
            this.LabelDataHora.AutoSize = true;
            this.LabelDataHora.Location = new System.Drawing.Point(273, 133);
            this.LabelDataHora.Name = "LabelDataHora";
            this.LabelDataHora.Size = new System.Drawing.Size(51, 13);
            this.LabelDataHora.TabIndex = 50;
            this.LabelDataHora.Text = "Datahora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(287, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 37;
            // 
            // ProdutoListDataGrid
            // 
            this.ProdutoListDataGrid.AllowUserToOrderColumns = true;
            this.ProdutoListDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProdutoListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdutoListDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProdutoListDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdutoListDataGrid.Enabled = false;
            this.ProdutoListDataGrid.Location = new System.Drawing.Point(3, 16);
            this.ProdutoListDataGrid.Name = "ProdutoListDataGrid";
            this.ProdutoListDataGrid.Size = new System.Drawing.Size(847, 411);
            this.ProdutoListDataGrid.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.LabelDataHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 39);
            this.panel1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Data / hora de abertura: ";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox11.Location = new System.Drawing.Point(0, 0);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox11.Size = new System.Drawing.Size(875, 37);
            this.textBox11.TabIndex = 35;
            this.textBox11.Text = "Controle de Caixa Por Funcionário";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
<<<<<<< HEAD
            // btnFecharCaixa
=======
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::CrudExemplos.Properties.Resources.internet_locked_padlock_password_secure_security_unlock_icon_127083;
            this.button2.Location = new System.Drawing.Point(44, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Abrir Caixa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
>>>>>>> c838a56767ad5ebd5085c328102739e7487b4838
            // 
            this.btnFecharCaixa.BackColor = System.Drawing.Color.Crimson;
            this.btnFecharCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharCaixa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFecharCaixa.Image = global::CrudExemplos.Properties.Resources.internet_locked_padlock_password_secure_security_unlock_icon_127083;
            this.btnFecharCaixa.Location = new System.Drawing.Point(539, 589);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(121, 39);
            this.btnFecharCaixa.TabIndex = 9;
            this.btnFecharCaixa.Text = "Excluir";
            this.btnFecharCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFecharCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFecharCaixa.UseVisualStyleBackColor = false;
            // 
            // cmbBarbeiro
            // 
            this.cmbBarbeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarbeiro.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbBarbeiro.FormattingEnabled = true;
            this.cmbBarbeiro.Location = new System.Drawing.Point(177, 61);
            this.cmbBarbeiro.Name = "cmbBarbeiro";
            this.cmbBarbeiro.Size = new System.Drawing.Size(132, 23);
            this.cmbBarbeiro.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(111, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Barbeiro:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Image = global::CrudExemplos.Properties.Resources.lupa;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-129, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 20);
            this.button5.TabIndex = 66;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.BackColor = System.Drawing.Color.Green;
            this.btnAbrirCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaixa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbrirCaixa.Image = global::CrudExemplos.Properties.Resources.internet_locked_padlock_password_secure_security_unlock_icon_127083;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(397, 589);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(134, 39);
            this.btnAbrirCaixa.TabIndex = 68;
            this.btnAbrirCaixa.Text = "Realizar Acerto";
            this.btnAbrirCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirCaixa.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
<<<<<<< HEAD
            this.button6.BackColor = System.Drawing.Color.Turquoise;
=======
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button6.BackColor = System.Drawing.Color.Transparent;
>>>>>>> c838a56767ad5ebd5085c328102739e7487b4838
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Image = global::CrudExemplos.Properties.Resources._1486564724_pencil_81530;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(668, 589);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 39);
            this.button6.TabIndex = 39;
            this.button6.Text = "Adicionar Entrada / Saída";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
<<<<<<< HEAD
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.cmbBarbeiro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 102);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Cod:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(39, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 20);
            this.textBox2.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(687, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Ate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(555, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "De:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(723, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 21);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "yyyy-MM-dd";
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(585, 63);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(96, 21);
            this.dtData.TabIndex = 68;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProdutoListDataGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 430);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(385, 61);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(132, 21);
            this.cmbStatus.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Status:";
            // 
=======
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(685, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 492);
            this.panel2.TabIndex = 52;
            // 
>>>>>>> c838a56767ad5ebd5085c328102739e7487b4838
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(877, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbrirCaixa);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFecharCaixa);
            this.Name = "Caixa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoListDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDataHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ProdutoListDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFecharCaixa;
        public System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ComboBox cmbBarbeiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
    }
}