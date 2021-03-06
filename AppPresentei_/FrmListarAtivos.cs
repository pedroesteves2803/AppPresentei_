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
    public partial class FrmListarAtivos : Form
    {
        public FrmListarAtivos()
        {
            InitializeComponent();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            var qtd = 0;
            Empresa empresa = new Empresa();
            listBoxAtivos.Items.Clear();
            foreach (var empresas in empresa.BuscarTodosAtivos())
            {
                listBoxAtivos.Items.Add("ID EMPRESA: " + empresas.Id + "          " + "EMPRESA: " + empresas.Nome + "          " + "CNPJ: " + empresas.Cnpj);
                qtd += 1;
                txtQtd.Text = Convert.ToString(qtd);
            }
        }

        private void FrmListarAtivos_Load(object sender, EventArgs e)
        {
            var qtd = 0;
            Empresa empresa = new Empresa();
            listBoxAtivos.Items.Clear();
            foreach (var empresas in empresa.BuscarTodosAtivos())
            {
                listBoxAtivos.Items.Add("ID EMPRESA: " + empresas.Id + "          " + "EMPRESA: " + empresas.Nome + "          " + "CNPJ: " + empresas.Cnpj);
                qtd += 1;
                txtQtd.Text = Convert.ToString(qtd);
            }
        }
    }
}
