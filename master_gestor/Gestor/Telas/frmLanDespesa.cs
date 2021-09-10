using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor.Telas
{
    public partial class frmLanDespesa : Form
    {
        public frmLanDespesa()
        {
            InitializeComponent();
        }

        private void frmLanDespesa_Load(object sender, EventArgs e)
        {
            Inicializa();
        }

        bool bValida = false;

        public static string sScriptParcelas = "INSERT INTO public.fordocdoc(codigofornecedor, documento, " +
             "dataemissao, datavencimento, , " +
             "valor, qtdparcelas, parcela, entrada) " +
             "VALUES({0},'{1}','{2}','{3}','{4}',{5},{6},{7});";

        private void Inicializa()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtDocumento.Clear();
            dtDataEmissao.Value = DateTime.Now;
            raTotal.Checked = true;
            nmParcelas.Enabled = true;
            nmParcelas.Value = 1;
            txtValor.Clear();
            dtParcelas.DataSource = null;
        }

        private void AtualizaDados()
        {
            try
            {
                bValida = false;
                DateTime dtEmissaoParcela = dtDataEmissao.Value;
                int iDias = 30;
                DateTime dtVencimentoParcela = dtDataEmissao.Value.AddDays(iDias);
                int iParcelas = Convert.ToInt32(nmParcelas.Value);
                string sValor = txtValor.Text;
                if (dtParcelas.Rows.Count > 0)
                {
                    dtParcelas.Rows.Clear();
                }
                if (txtValor.Text != "     ," && Convert.ToDouble(txtValor.Text) > 0.01)
                {
                    if (raParcela.Checked)
                    {
                        dtParcelas.Rows.Add("1", iDias, dtVencimentoParcela, sValor,false);
                        bValida = true;
                    }
                    else if (raTotal.Checked)
                    {
                        decimal dValor = Math.Round(((Convert.ToDecimal(sValor)) / iParcelas), 2);

                        for (int iContador = 0; iContador < iParcelas; iContador++)
                        {
                            dtParcelas.Rows.Add(iContador + 1, (iDias + (30 * iContador)), dtVencimentoParcela, dValor,false);
                            dtVencimentoParcela.AddDays(iDias);
                            bValida = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool ValidaCampos()
        {
            bool bValidacao = false;

            if (txtCodigo.Text != string.Empty) bValidacao = true;
            else bValidacao = false;

            if (txtDocumento.Text != string.Empty) bValidacao = true;
            else bValidacao = false;

            return bValidacao;
        }

        private void raParcela_CheckedChanged(object sender, EventArgs e)
        {
            nmParcelas.Enabled = false;
            AtualizaDados();
        }

        private void raTotal_CheckedChanged(object sender, EventArgs e)
        {
            nmParcelas.Enabled = true;
            AtualizaDados();
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            AtualizaDados();
        }

        private void dtDataEmissao_Leave(object sender, EventArgs e)
        {
            AtualizaDados();
        }

        private void nmParcelas_ValueChanged(object sender, EventArgs e)
        {
            AtualizaDados();
        }

        private void nmParcelas_Leave(object sender, EventArgs e)
        {
            AtualizaDados();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            AtualizaDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (bValida && ValidaCampos())
            {
                string sTexto= "";
                string sCodigoFornecedor = txtCodigo.Text;
                string sDocumento = txtDocumento.Text;
                string sValor = "";
                string sParcelas = nmParcelas.Value.ToString(); ;
                string sParcela = "";
                string sDataEmissao = dtDataEmissao.Value.ToString();
                string sDataVencimento = "";
                string sEntrada = "";
                try
                {

                    if (raParcela.Checked)
                    {
                        sDataVencimento = dtParcelas.Rows[1].Cells["DataVencimento"].Value.ToString();
                        sEntrada = dtParcelas.Rows[1].Cells["Entrada"].Value.ToString();
                        sValor = txtValor.Text;
                        sTexto = String.Format(sScriptParcelas, sCodigoFornecedor, sDocumento, 
                            sDataEmissao, sDataVencimento, sValor, sParcelas, sParcelas, sEntrada);
                        MessageBox.Show(sTexto);
                    }
                    else if(raTotal.Checked)
                    {
                        for (int iContatorRowGrig = 0; iContatorRowGrig < dtParcelas.Rows.Count; iContatorRowGrig++)
                        {
                            sDataVencimento = dtParcelas.Rows[iContatorRowGrig].Cells["DataVencimento"].Value.ToString();
                            sEntrada = dtParcelas.Rows[iContatorRowGrig].Cells["Entrada"].Value.ToString();
                            sValor = dtParcelas.Rows[iContatorRowGrig].Cells["Valor"].Value.ToString();
                            sTexto += String.Format(sScriptParcelas, sCodigoFornecedor, sDocumento,
                                sDataEmissao, sDataVencimento, sValor, sParcelas, sParcelas, sEntrada) +"\r\n";
                        }
                        MessageBox.Show(sTexto);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
