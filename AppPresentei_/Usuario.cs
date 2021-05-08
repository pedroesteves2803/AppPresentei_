using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppPresentei_
{


    public class Usuario
    {
        private int id;
        private string nome;
        private string cnpj;
        private string senha;
        private string nomeCartao;
        private string numeroCartao;
        private string digitos;
        private int status;


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Senha { get => senha; set => senha = value; }
        public string NomeCartao { get => nomeCartao; set => nomeCartao = value; }
        public string NumeroCartao { get => numeroCartao; set => numeroCartao = value; }
        public string Digitos { get => digitos; set => digitos = value; }
        public int Status { get => status; set => status = value; }

        public Usuario(string cnpj, string senha, int status = 0)
        {
            this.cnpj = cnpj;
            this.senha = senha;
            this.status = status;
        }
        public Usuario()
        {

        }

        public bool EfetuarLogin(Usuario usuario)
        {
            bool valido = false;
            var cmd = Banco.AbrirConexao();
            cmd.CommandText =
                "select * from tb_empresas where senha_empresa = md5(@senha) and cnpj_empresa = @cnpj and status_empresa = 1;";
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Senha;
            cmd.Parameters.Add("@cnpj", MySqlDbType.VarChar).Value = usuario.cnpj;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                cnpj = dr.GetString(2);
                Senha = dr.GetString(3);
                nomeCartao = dr.GetString(4);
                numeroCartao = dr.GetString(5);
                digitos = dr.GetString(6);
                status = dr.GetInt32(7);
                valido = true;
            }

            Program.idLogado = usuario;


            return valido;
        }


    }
}
