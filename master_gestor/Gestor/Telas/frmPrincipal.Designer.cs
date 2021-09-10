namespace Gestor.Telas
{
    partial class frmPrincipal
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
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.muArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.miConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            this.miSair = new System.Windows.Forms.ToolStripMenuItem();
            this.muContasReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.miCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.miLancReceitaCli = new System.Windows.Forms.ToolStripMenuItem();
            this.miBaixaPrestaCli = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoReceitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miContasPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.miCadFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.miLancDespesaFor = new System.Windows.Forms.ToolStripMenuItem();
            this.miBaixaPagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.miCadTipoDespesa = new System.Windows.Forms.ToolStripMenuItem();
            this.muVeiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.miCadVeiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.miCompraVeiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.miDocVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.miManutencaoVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.miVendaVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muArquivo,
            this.muContasReceber,
            this.miContasPagar,
            this.muVeiculos});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnPrincipal.TabIndex = 1;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // muArquivo
            // 
            this.muArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConfiguracao,
            this.miSair});
            this.muArquivo.Name = "muArquivo";
            this.muArquivo.Size = new System.Drawing.Size(62, 20);
            this.muArquivo.Text = "Arquivo";
            // 
            // miConfiguracao
            // 
            this.miConfiguracao.Name = "miConfiguracao";
            this.miConfiguracao.Size = new System.Drawing.Size(154, 22);
            this.miConfiguracao.Text = "Configuração ";
            // 
            // miSair
            // 
            this.miSair.Name = "miSair";
            this.miSair.Size = new System.Drawing.Size(154, 22);
            this.miSair.Text = "Sair";
            // 
            // muContasReceber
            // 
            this.muContasReceber.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCadCliente,
            this.miLancReceitaCli,
            this.miBaixaPrestaCli,
            this.tipoReceitaToolStripMenuItem});
            this.muContasReceber.Name = "muContasReceber";
            this.muContasReceber.Size = new System.Drawing.Size(119, 20);
            this.muContasReceber.Text = "Contas a Receber";
            // 
            // miCadCliente
            // 
            this.miCadCliente.Name = "miCadCliente";
            this.miCadCliente.Size = new System.Drawing.Size(209, 22);
            this.miCadCliente.Text = "Cadastro de Cliente";
            // 
            // miLancReceitaCli
            // 
            this.miLancReceitaCli.Name = "miLancReceitaCli";
            this.miLancReceitaCli.Size = new System.Drawing.Size(209, 22);
            this.miLancReceitaCli.Text = "Lançamento de Receita";
            // 
            // miBaixaPrestaCli
            // 
            this.miBaixaPrestaCli.Name = "miBaixaPrestaCli";
            this.miBaixaPrestaCli.Size = new System.Drawing.Size(209, 22);
            this.miBaixaPrestaCli.Text = "Baixa de Presastações";
            // 
            // tipoReceitaToolStripMenuItem
            // 
            this.tipoReceitaToolStripMenuItem.Name = "tipoReceitaToolStripMenuItem";
            this.tipoReceitaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.tipoReceitaToolStripMenuItem.Text = "Tipo Receita";
            // 
            // miContasPagar
            // 
            this.miContasPagar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCadFornecedor,
            this.miLancDespesaFor,
            this.miBaixaPagamento,
            this.miCadTipoDespesa});
            this.miContasPagar.Name = "miContasPagar";
            this.miContasPagar.Size = new System.Drawing.Size(106, 20);
            this.miContasPagar.Text = "Contas a Pagar";
            // 
            // miCadFornecedor
            // 
            this.miCadFornecedor.Name = "miCadFornecedor";
            this.miCadFornecedor.Size = new System.Drawing.Size(213, 22);
            this.miCadFornecedor.Text = "Cadastro de Fornecedor";
            // 
            // miLancDespesaFor
            // 
            this.miLancDespesaFor.Name = "miLancDespesaFor";
            this.miLancDespesaFor.Size = new System.Drawing.Size(213, 22);
            this.miLancDespesaFor.Text = "Lancamento de Despesa";
            this.miLancDespesaFor.Click += new System.EventHandler(this.miLancDespesaFor_Click);
            // 
            // miBaixaPagamento
            // 
            this.miBaixaPagamento.Name = "miBaixaPagamento";
            this.miBaixaPagamento.Size = new System.Drawing.Size(213, 22);
            this.miBaixaPagamento.Text = "Baixa de Pagamentos";
            // 
            // miCadTipoDespesa
            // 
            this.miCadTipoDespesa.Name = "miCadTipoDespesa";
            this.miCadTipoDespesa.Size = new System.Drawing.Size(213, 22);
            this.miCadTipoDespesa.Text = "Tipos de Despesa";
            // 
            // muVeiculos
            // 
            this.muVeiculos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCadVeiculos,
            this.miCompraVeiculos,
            this.miDocVeiculo,
            this.miManutencaoVeiculo,
            this.miVendaVeiculo});
            this.muVeiculos.Name = "muVeiculos";
            this.muVeiculos.Size = new System.Drawing.Size(63, 20);
            this.muVeiculos.Text = "Veiculos";
            // 
            // miCadVeiculos
            // 
            this.miCadVeiculos.Name = "miCadVeiculos";
            this.miCadVeiculos.Size = new System.Drawing.Size(191, 22);
            this.miCadVeiculos.Text = "Cadastro de Veículos";
            // 
            // miCompraVeiculos
            // 
            this.miCompraVeiculos.Name = "miCompraVeiculos";
            this.miCompraVeiculos.Size = new System.Drawing.Size(191, 22);
            this.miCompraVeiculos.Text = "Compra de Veículos";
            // 
            // miDocVeiculo
            // 
            this.miDocVeiculo.Name = "miDocVeiculo";
            this.miDocVeiculo.Size = new System.Drawing.Size(191, 22);
            this.miDocVeiculo.Text = "Documentação";
            // 
            // miManutencaoVeiculo
            // 
            this.miManutencaoVeiculo.Name = "miManutencaoVeiculo";
            this.miManutencaoVeiculo.Size = new System.Drawing.Size(191, 22);
            this.miManutencaoVeiculo.Text = "Manutenção";
            // 
            // miVendaVeiculo
            // 
            this.miVendaVeiculo.Name = "miVendaVeiculo";
            this.miVendaVeiculo.Size = new System.Drawing.Size(191, 22);
            this.miVendaVeiculo.Text = "Venda de Veículos";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem muArquivo;
        private System.Windows.Forms.ToolStripMenuItem miConfiguracao;
        private System.Windows.Forms.ToolStripMenuItem miSair;
        private System.Windows.Forms.ToolStripMenuItem muContasReceber;
        private System.Windows.Forms.ToolStripMenuItem miCadCliente;
        private System.Windows.Forms.ToolStripMenuItem miLancReceitaCli;
        private System.Windows.Forms.ToolStripMenuItem miBaixaPrestaCli;
        private System.Windows.Forms.ToolStripMenuItem tipoReceitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miContasPagar;
        private System.Windows.Forms.ToolStripMenuItem miCadFornecedor;
        private System.Windows.Forms.ToolStripMenuItem miLancDespesaFor;
        private System.Windows.Forms.ToolStripMenuItem miBaixaPagamento;
        private System.Windows.Forms.ToolStripMenuItem miCadTipoDespesa;
        private System.Windows.Forms.ToolStripMenuItem muVeiculos;
        private System.Windows.Forms.ToolStripMenuItem miCadVeiculos;
        private System.Windows.Forms.ToolStripMenuItem miCompraVeiculos;
        private System.Windows.Forms.ToolStripMenuItem miDocVeiculo;
        private System.Windows.Forms.ToolStripMenuItem miManutencaoVeiculo;
        private System.Windows.Forms.ToolStripMenuItem miVendaVeiculo;
    }
}