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
        private string senhaNormal;
        private string nomeCartao;
        private string numeroCartao;
        private string digitos;




        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Senha { get => senha; set => senha = value; }
        public string NomeCartao { get => nomeCartao; set => nomeCartao = value; }
        public string NumeroCartao { get => numeroCartao; set => numeroCartao = value; }
        public string Digitos { get => digitos; set => digitos = value; }
        public string SenhaNormal { get => senhaNormal; set => senhaNormal = value; }

        public Empresa(string nome, string cnpj, string senha, string nomeCartao, string numeroCartao, string digitos)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.senha = senha;
            this.nomeCartao = nomeCartao;
            this.numeroCartao = numeroCartao;
            this.digitos = digitos;
        }

        public Empresa(int id,string nome, string cnpj)
        {
            this.id = id;
            this.nome = nome;
            this.cnpj = cnpj;

        }


        public Empresa()
        {
        }

        public void Inserir(Empresa empresa)
        {
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "insert tb_empresas values(null, @nome_empresa, @cnpj_empresa, md5(@senha_empresa), @senha_empresa, @nomeCartao_empresa, @numeroCartao_empresa, @digitos_empresa, @status_empresa);";
            cmd.Parameters.Add("@nome_empresa", MySqlDbType.VarChar).Value = empresa.Nome;
            cmd.Parameters.Add("@cnpj_empresa", MySqlDbType.VarChar).Value = empresa.Cnpj;
            cmd.Parameters.Add("@senha_empresa", MySqlDbType.VarChar).Value = empresa.Senha;
            cmd.Parameters.Add("@nomeCartao_empresa", MySqlDbType.VarChar).Value = empresa.nomeCartao;
            cmd.Parameters.Add("@numeroCartao_empresa", MySqlDbType.VarChar).Value = empresa.numeroCartao;
            cmd.Parameters.Add("@digitos_empresa", MySqlDbType.VarChar).Value = empresa.digitos;
            cmd.Parameters.Add("@status_empresa", MySqlDbType.VarChar).Value = 1;
            cmd.ExecuteNonQuery();
        }

        public void Alterar(Empresa empresa)
        {
            MySqlCommand cmd = Banco.AbrirConexao();
            cmd.CommandText = "update tb_empresas set nome_empresa = @nome_empresa ,  cnpj_empresa = @cnpj_empresa, senha_empresa = md5(@senha_empresa), " +
            "senhaNormal_empresa = @senha_empresa, nomeCartao_empresa = @nomeCartao_empresa, numeroCartao_empresa = @numeroCartao_empresa, digitos_empresa = @digitos_empresa where id_empresa = " + Program.idLogado.Id;
            cmd.Parameters.Add("@nome_empresa", MySqlDbType.VarChar).Value = empresa.Nome;
            cmd.Parameters.Add("@cnpj_empresa", MySqlDbType.VarChar).Value = empresa.Cnpj;
            cmd.Parameters.Add("@senha_empresa", MySqlDbType.VarChar).Value = empresa.Senha;
            cmd.Parameters.Add("@nomeCartao_empresa", MySqlDbType.VarChar).Value = empresa.nomeCartao;
            cmd.Parameters.Add("@numeroCartao_empresa", MySqlDbType.VarChar).Value = empresa.numeroCartao;
            cmd.Parameters.Add("@digitos_empresa", MySqlDbType.VarChar).Value = empresa.digitos;
            cmd.ExecuteNonQuery();
        }

        public void PegarSenha()
        {
            var cmd = Banco.AbrirConexao();
            cmd.CommandText =
                "select * from tb_empresas where id_empresa = " + Program.idLogado.Id;

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                cnpj = dr.GetString(2);
                Senha = dr.GetString(3);
                senhaNormal = dr.GetString(4);
                nomeCartao = dr.GetString(5);
                numeroCartao = dr.GetString(7);
                digitos = dr.GetString(8);

            }

        }

        public void Desativar()
        {
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "call mudarStatusEmpresa(" + Program.idLogado.Id + ");";
            cmd.ExecuteNonQuery();
        }

        public List<Empresa> BuscarTodos()
        {
            List<Empresa> item = new List<Empresa>();
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_empresas ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item.Add(
                    new Empresa(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                        ));
            }
            return item;
        }

        public List<Empresa> BuscarTodosAtivos()
        {
            List<Empresa> item = new List<Empresa>();
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_empresas where status_empresa = 1 ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item.Add(
                    new Empresa(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                        ));
            }
            return item;
        }

        public List<Empresa> BuscarTodosDesativos()
        {
            List<Empresa> item = new List<Empresa>();
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_empresas where status_empresa = 2 ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item.Add(
                    new Empresa(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                        ));
            }
            return item;
        }




    }
}
