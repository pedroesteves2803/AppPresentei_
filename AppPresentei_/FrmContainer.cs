using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPresentei_
{
    public partial class FrmContainer : Form
    {
        public FrmContainer()
        {
            InitializeComponent();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItems frmItems = new FrmItems();
            frmItems.MdiParent = this;
            frmItems.Show();
            
        }

        private void FrmContainer_Load(object sender, EventArgs e)
        {
            FrmItems frmItems = new FrmItems();
            frmItems.MdiParent = this;
            frmItems.Show();
        }

        private void alterarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmalterar frmalterar = new Frmalterar();
            frmalterar.MdiParent = this;
            frmalterar.Show();
        }

        private void verProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarProduto listar = new FrmListarProduto();
            listar.MdiParent = this;
            listar.Show();
        }

        private void minhaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlterarEmpresa frmAlterarEmpresa = new FrmAlterarEmpresa();
            frmAlterarEmpresa.MdiParent = this;
            frmAlterarEmpresa.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Visible = true;
        }
    }
}
