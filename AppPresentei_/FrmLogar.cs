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
    public partial class FrmLogar : Form
    {
        public FrmLogar()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtEmail.Text, txtSenha.Text);

            if (txtEmail.Text == "admin" && txtSenha.Text == "admin")
            {
                MessageBox.Show("Bem vindo admin !!!");
                FrmContainerAdmin frmAdmin = new FrmContainerAdmin();
                frmAdmin.Show();
                this.Close();

            }

            else
            {
                if (usuario.EfetuarLogin(usuario))
                {

                    MessageBox.Show("Login feito com sucesso !!!");
                    this.Close();

                    FrmContainer frmcontainer = new FrmContainer();
                    frmcontainer.Show();
                    
                    //Program.usuarioLogado = usuario;

                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalido !!!");
                }
            }
        }

        private void BtnVoltar_Click_1(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Visible = true;
            this.Close();
        }
    }
}
