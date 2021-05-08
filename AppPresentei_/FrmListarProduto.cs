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
    public partial class FrmListarProduto : Form
    {
        public FrmListarProduto()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            listBoxProdutos.Items.Clear();
            foreach (var produto in item.BuscarTodos())
            {
                listBoxProdutos.Items.Add("ID produto: " + produto.Id + " - " + "Produto: " + produto.Nome + " - " + "Imagem: " + produto.Imagem +
                " - " + "Valor: " + produto.Valor + " - " + "Link :" + produto.Link + " - " + "Id empresa: " + produto.IdEmpresa + " - " + "Marca: " 
                + produto.Marca);
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Exluir(int.Parse(txtIdProduto.Text));
            MessageBox.Show("Produto excluido !");
        }
    }
}
