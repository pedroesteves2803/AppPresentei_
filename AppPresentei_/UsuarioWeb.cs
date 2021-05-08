using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppPresentei_
{
    public class UsuarioWeb
    {

        private int id;
        private string nome;
        private string email;
        private string telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public UsuarioWeb(int id, string nome, string email, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

        public UsuarioWeb()
        {

        }

        public List<UsuarioWeb> BuscarTodos()
        {
            List<UsuarioWeb> item = new List<UsuarioWeb>();
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_usuario ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item.Add(
                    new UsuarioWeb(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(1)
                        ));
            }
            return item;
        }


    }
}
