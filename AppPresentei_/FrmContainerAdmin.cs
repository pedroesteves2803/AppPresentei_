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
    public partial class FrmContainerAdmin : Form
    {
        public FrmContainerAdmin()
        {
            InitializeComponent();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarTodasEmpresas frmListarTodasEmpresas = new FrmListarTodasEmpresas();
            frmListarTodasEmpresas.MdiParent = this;
            frmListarTodasEmpresas.Show();
        }

        private void FrmContainerAdmin_Load(object sender, EventArgs e)
        {
            FrmListarTodasEmpresas frmListarTodasEmpresas = new FrmListarTodasEmpresas();
            frmListarTodasEmpresas.MdiParent = this;
            frmListarTodasEmpresas.Show();
        }

        private void alterarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarTodosUsuarios frmListarTodos = new FrmListarTodosUsuarios();
            frmListarTodos.MdiParent = this;
            frmListarTodos.Show();
        }

        private void verProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarAtivos frmListarAtivos = new FrmListarAtivos();
            frmListarAtivos.MdiParent = this;
            frmListarAtivos.Show();
        }

        private void minhaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarDesativados frmListarDesativados = new FrmListarDesativados();
            frmListarDesativados.MdiParent = this;
            frmListarDesativados.Show();
        }
    }
}
