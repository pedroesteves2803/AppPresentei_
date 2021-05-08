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
    public partial class FrmItems : Form
    {
        public FrmItems()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Item item = new Item(txtProduto.Text, txtValor.Text, txtLink.Text, txtLinkImg.Text, txtMarca.Text);
            item.Inserir(item);
            MessageBox.Show("Salvo !!!!");
            txtProduto.Clear();
            txtValor.Clear();
            txtLink.Clear();
            txtLinkImg.Clear();
            txtMarca.Clear();

        }

    }
}
