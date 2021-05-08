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
    public partial class FrmCadastrarEmpresa : Form
    {
        public FrmCadastrarEmpresa()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa(txtNome.Text, txtCnpj.Text, txtSenha.Text, CmbNomeCatao.Text, txtNumero.Text, txtDigito.Text);
            empresa.Inserir(empresa);
            MessageBox.Show("Bem vindo(a) !!!!");
            FrmLogar logar = new FrmLogar();
            logar.ShowDialog();
            this.Close();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Visible = true;
            this.Close();
        }
    }
}
