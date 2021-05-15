using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppPresentei_
{
    public class Empresa
    {
        private int id;
        private string nome;
        private string cnpj;
        private string senha;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Senha { get => senha; set => senha = value; }
        public string SenhaNormal { get => senha; set => senha = value; }

        public Empresa()
        {
        }

        public Empresa(int id, string nome, string cnpj, string senha)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            Senha = senha;
        }

        public Empresa(string nome, string cnpj, string senha)
        {
            Nome = nome;
            Cnpj = cnpj;
            Senha = senha;
        }

        public void Inserir(Empresa empresa)
        {
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "insert tb_empresa values(null, @nome_empresa, @cnpj_empresa, md5(@senha_empresa), @status_empresa);";
            cmd.Parameters.Add("@nome_empresa", MySqlDbType.VarChar).Value = empresa.Nome;
            cmd.Parameters.Add("@cnpj_empresa", MySqlDbType.VarChar).Value = empresa.Cnpj;
            cmd.Parameters.Add("@senha_empresa", MySqlDbType.VarChar).Value = empresa.Senha;
            cmd.Parameters.Add("@status_empresa", MySqlDbType.VarChar).Value = 1;
            cmd.ExecuteNonQuery();
        }

        public void Alterar(Empresa empresa)
        {
            MySqlCommand cmd = Banco.AbrirConexao();
            cmd.CommandText = "update tb_empresa set nome_empresa = @nome_empresa ,  cnpj_empresa = @cnpj_empresa, senha_empresa = md5(@senha_empresa) where id_empresa = " + Program.idLogado.Id;
            cmd.Parameters.Add("@nome_empresa", MySqlDbType.VarChar).Value = empresa.Nome;
            cmd.Parameters.Add("@cnpj_empresa", MySqlDbType.VarChar).Value = empresa.Cnpj;
            cmd.Parameters.Add("@senha_empresa", MySqlDbType.VarChar).Value = empresa.Senha;
            cmd.ExecuteNonQuery();
        }

        public void PegarSenha()
        {
            var cmd = Banco.AbrirConexao();
            cmd.CommandText =
                "select * from tb_empresa where id_empresa = " + Program.idLogado.Id;

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                cnpj = dr.GetString(2);
                Senha = dr.GetString(3);

            }

        }

        public void Desativar()
        {
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "update tb_empresa set status_empresa = 2 where id_empresa = " + Program.idLogado.Id;
            cmd.ExecuteNonQuery();
        }

        public List<Empresa> BuscarTodos()
        {
            List<Empresa> item = new List<Empresa>();
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_empresa";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item.Add(
                    new Empresa(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                         dr.GetString(3)
                        ));
            }
            return item;
        }

        public List<Empresa> BuscarTodosAtivos()
        {
            List<Empresa> item = new List<Empresa>();
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_empresa where status_empresa = 1 ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item.Add(
                    new Empresa(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                         dr.GetString(3)
                        ));
            }
            return item;
        }

        public List<Empresa> BuscarTodosDesativos()
        {
            List<Empresa> item = new List<Empresa>();
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_empresa where status_empresa = 2 ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item.Add(
                    new Empresa(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                         dr.GetString(3)
                        ));
            }
            return item;
        }




    }
}
