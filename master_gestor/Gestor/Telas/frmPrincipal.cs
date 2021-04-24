using Gestor.Classes;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Inicializa();
        }

        private void Inicializa()
        {
            clsBanco.Fu_MontaConexao();
            clsScripts.iVersaoBanco = clsBanco.Fu_RetornaVersaoBanco();
            if (clsScripts.iVersaoBanco < clsScripts.iVersaoOficial)
            {
                clsScripts.ExecutaAtualizacao();
            }
        }
    }
}
