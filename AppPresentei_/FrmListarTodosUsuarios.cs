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
    public partial class FrmListarTodosUsuarios : Form
    {
        public FrmListarTodosUsuarios()
        {
            InitializeComponent();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

            var qtd = 0;
            UsuarioWeb usuario = new UsuarioWeb();
            listBoxUsuarios.Items.Clear();
            foreach (var usuarios in usuario.BuscarTodos())
            {
                listBoxUsuarios.Items.Add("ID USUARIO: " + usuarios.Id + "          " + "USUARIO: " + usuarios.Nome + "          " + "EMAIL: " + usuarios.Email + "          " + "TELEFONE: " + usuarios.Telefone);

                qtd += 1;
                txtQtd.Text = Convert.ToString(qtd);
            }
        }

        private void FrmListarTodosUsuarios_Load(object sender, EventArgs e)
        {
            var qtd = 0;
            UsuarioWeb usuario = new UsuarioWeb();
            listBoxUsuarios.Items.Clear();
            foreach (var usuarios in usuario.BuscarTodos())
            {
                listBoxUsuarios.Items.Add("ID USUARIO: " + usuarios.Id + "          " + "USUARIO: " + usuarios.Nome + "          " + "EMAIL: " + usuarios.Email + "          " + "TELEFONE: " + usuarios.Telefone);
                qtd += 1;
                txtQtd.Text = Convert.ToString(qtd);
            }
        }
    }
}
