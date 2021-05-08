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
    public partial class FrmAlterarEmpresa : Form
    {
        public FrmAlterarEmpresa()
        {
            InitializeComponent();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.PegarSenha();
            if (empresa.SenhaNormal == txtSenhaAntiga.Text)
            {
                empresa.Nome = txtNome.Text;
                empresa.Cnpj = txtCnpj.Text;
                empresa.Senha = txtSenhaNova.Text;
                empresa.NomeCartao = txtNome.Text;
                empresa.NumeroCartao = txtNumero.Text;
                empresa.Digitos = txtDigito.Text;
                empresa.Alterar(empresa);
                MessageBox.Show("Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("senha antiga incorreta!");
                txtSenhaAntiga.Focus();
            }
        }

        private void BtnDesativar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Desativar();
            MessageBox.Show("Conta desativada, da proxima vez que tentar logar sua entrará !!");
            //FrmPrincipal principal = new FrmPrincipal();
            //principal.Visible = true;

        }
    }
}
