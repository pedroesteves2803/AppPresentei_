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
    public partial class Frmalterar : Form
    {
        public Frmalterar()
        {
            InitializeComponent();
        }

        private void BtnbuscarPorNome_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != string.Empty)
            {
                Read_verdadeiro();
                Item item = new Item();
                item.BuscarPorId(txtProduto.Text);
                if (item.Nome != "" )
                {
                    Program.idProduto = Convert.ToString(item.IdProduto);
                    txtProduto.Text = item.Nome;
                    txtValor.Text = item.Valor;
                    txtLink.Text = item.Link;
                    txtLinkImg.Text = item.Imagem;
                    txtMarca.Text = item.Marca;
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.IdProduto = int.Parse(Program.idProduto);
            item.Nome = txtProduto.Text;
            item.Valor = txtValor.Text;
            item.Link = txtLink.Text;
            item.Imagem = txtLinkImg.Text;
            item.Marca = txtMarca.Text;
            item.Alterar(item);
            MessageBox.Show("Aluno Alterado com sucesso!");
            txtProduto.Clear();
            txtValor.Clear();
            txtLink.Clear();
            txtLinkImg.Clear();
            txtMarca.Clear();
        }

        private void Read_verdadeiro()
        {
            txtValor.ReadOnly = false;
            txtLink.ReadOnly = false;
            txtLinkImg.ReadOnly = false;
            txtMarca.ReadOnly = false;
        }

    }
}
