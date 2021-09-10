namespace Gestor.Telas
{
    partial class frmLanDespesa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmParcelas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.raTotal = new System.Windows.Forms.RadioButton();
            this.raParcela = new System.Windows.Forms.RadioButton();
            this.dtParcelas = new System.Windows.Forms.DataGridView();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 65);
            this.panel1.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 28);
            this.txtCodigo.Mask = "00000";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PromptChar = ' ';
            this.txtCodigo.Size = new System.Drawing.Size(78, 21);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(96, 28);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(370, 21);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo (F4):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 70);
            this.panel2.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(372, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(117, 70);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(489, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 70);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.White;
            this.txtDocumento.Location = new System.Drawing.Point(9, 96);
            this.txtDocumento.MaxLength = 20;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(151, 21);
            this.txtDocumento.TabIndex = 5;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDocumento.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data da Emissão:";
            // 
            // dtDataEmissao
            // 
            this.dtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEmissao.Location = new System.Drawing.Point(9, 139);
            this.dtDataEmissao.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtDataEmissao.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtDataEmissao.Name = "dtDataEmissao";
            this.dtDataEmissao.Size = new System.Drawing.Size(151, 21);
            this.dtDataEmissao.TabIndex = 8;
            this.dtDataEmissao.Value = new System.DateTime(2021, 9, 10, 0, 0, 0, 0);
            this.dtDataEmissao.Leave += new System.EventHandler(this.dtDataEmissao_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nmParcelas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.raTotal);
            this.groupBox1.Controls.Add(this.raParcela);
            this.groupBox1.Location = new System.Drawing.Point(9, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcelado/Total";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(3, 106);
            this.txtValor.Mask = "00000.00";
            this.txtValor.Name = "txtValor";
            this.txtValor.PromptChar = ' ';
            this.txtValor.Size = new System.Drawing.Size(123, 21);
            this.txtValor.TabIndex = 14;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor:";
            // 
            // nmParcelas
            // 
            this.nmParcelas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmParcelas.Location = new System.Drawing.Point(6, 62);
            this.nmParcelas.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nmParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmParcelas.Name = "nmParcelas";
            this.nmParcelas.Size = new System.Drawing.Size(120, 21);
            this.nmParcelas.TabIndex = 12;
            this.nmParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmParcelas.ValueChanged += new System.EventHandler(this.nmParcelas_ValueChanged);
            this.nmParcelas.Leave += new System.EventHandler(this.nmParcelas_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nº Parcelas:";
            // 
            // raTotal
            // 
            this.raTotal.AutoSize = true;
            this.raTotal.Location = new System.Drawing.Point(81, 20);
            this.raTotal.Name = "raTotal";
            this.raTotal.Size = new System.Drawing.Size(52, 20);
            this.raTotal.TabIndex = 1;
            this.raTotal.TabStop = true;
            this.raTotal.Text = "Total";
            this.raTotal.UseVisualStyleBackColor = true;
            this.raTotal.CheckedChanged += new System.EventHandler(this.raTotal_CheckedChanged);
            // 
            // raParcela
            // 
            this.raParcela.AutoSize = true;
            this.raParcela.Location = new System.Drawing.Point(7, 20);
            this.raParcela.Name = "raParcela";
            this.raParcela.Size = new System.Drawing.Size(68, 20);
            this.raParcela.TabIndex = 0;
            this.raParcela.TabStop = true;
            this.raParcela.Text = "Parcela";
            this.raParcela.UseVisualStyleBackColor = true;
            this.raParcela.CheckedChanged += new System.EventHandler(this.raParcela_CheckedChanged);
            // 
            // dtParcelas
            // 
            this.dtParcelas.AllowUserToAddRows = false;
            this.dtParcelas.AllowUserToDeleteRows = false;
            this.dtParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parcela,
            this.DiasVencimento,
            this.DataVencimento,
            this.Valor,
            this.Entrada});
            this.dtParcelas.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtParcelas.Location = new System.Drawing.Point(178, 65);
            this.dtParcelas.MultiSelect = false;
            this.dtParcelas.Name = "dtParcelas";
            this.dtParcelas.Size = new System.Drawing.Size(428, 276);
            this.dtParcelas.TabIndex = 10;
            // 
            // Parcela
            // 
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            this.Parcela.ReadOnly = true;
            // 
            // DiasVencimento
            // 
            this.DiasVencimento.HeaderText = "Dias";
            this.DiasVencimento.Name = "DiasVencimento";
            // 
            // DataVencimento
            // 
            this.DataVencimento.HeaderText = "Data Venciemento";
            this.DataVencimento.Name = "DataVencimento";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Entrada
            // 
            this.Entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            // 
            // frmLanDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 411);
            this.Controls.Add(this.dtParcelas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtDataEmissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLanDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Despesas";
            this.Load += new System.EventHandler(this.frmLanDespesa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDataEmissao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmParcelas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton raTotal;
        private System.Windows.Forms.RadioButton raParcela;
        private System.Windows.Forms.DataGridView dtParcelas;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Entrada;
    }
}