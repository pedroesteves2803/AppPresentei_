using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppPresentei_
{
    class Item
    {
        private int id;
        private string nome;
        private string imagem;
        private string valor;
        private string link;
        private int idProduto;
        private int idEmpresa;
        private string marca; 


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Link { get => link; set => link = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Marca { get => marca; set => marca = value; }

        public Item(string nome, string imagem, string valor, string link, string marca)
        {
            this.nome = nome;
            this.imagem = imagem;
            this.valor = valor;
            this.link = link;
            this.marca = marca;
        }

        public Item()
        {

        }

        public Item(int id, string nome, string imagem, string valor, string link, string marca, int idEmpresa = 0)
        {
            this.id = id;
            this.nome = nome;
            this.imagem = imagem;
            this.valor = valor;
            this.link = link;
            this.marca = marca;
            this.idEmpresa = idEmpresa;
        }

        public void Inserir(Item item)
        {

            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "insert tb_produtosEmpresas values(null, @nome_produto, @valor_produto, @link_produto, @imagem_produto, @marca_produto," + Program.idLogado.Id + ");";
            cmd.Parameters.Add("@nome_produto", MySqlDbType.VarChar).Value = item.Nome;
            cmd.Parameters.Add("@valor_produto", MySqlDbType.VarChar).Value = item.imagem;
            cmd.Parameters.Add("@link_produto", MySqlDbType.VarChar).Value = item.valor;
            cmd.Parameters.Add("@imagem_produto", MySqlDbType.VarChar).Value = item.valor;
            cmd.Parameters.Add("@marca_produto", MySqlDbType.VarChar).Value = item.marca;
            cmd.ExecuteNonQuery();
        }

        public void BuscarPorId(string nome)
        {
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_produtosEmpresas where nome_produto = " + nome;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                idProduto = dr.GetInt32(0);
                Nome = dr.GetString(1);
                valor = dr.GetString(2);
                link = dr.GetString(3);
                imagem = dr.GetString(4);
                ///idEmpresa = dr.GetInt32(5);
                marca = dr.GetString(6);
            }

        }

        public List<Item> BuscarTodos()
        {
            List<Item> item = new List<Item>();
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_produtosEmpresas where id_empresa =" + Program.idLogado.Id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item.Add(
                    new Item(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetInt32(6)
                        ));
            }
            return item;
        }

        public void Alterar(Item item) // para alterar aqui no visual e passar para o Mysql
        {
            MySqlCommand cmd = Banco.AbrirConexao();
            cmd.CommandText = "update tb_produtosEmpresas set nome_produto = @nome_produto ,  valor_produto = @valor_produto, link_produto = @link_produto, imagem_produto = @imagem_produto, marca_produto = @marca_produto where id_produto = @id ;";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = item.idProduto;
            cmd.Parameters.Add("@nome_produto", MySqlDbType.VarChar).Value = item.nome;
            cmd.Parameters.Add("@valor_produto", MySqlDbType.VarChar).Value = item.valor;
            cmd.Parameters.Add("@link_produto", MySqlDbType.VarChar).Value = item.link;
            cmd.Parameters.Add("@imagem_produto", MySqlDbType.VarChar).Value = item.imagem;
            cmd.Parameters.Add("@marca_produto", MySqlDbType.VarChar).Value = item.marca;
            cmd.ExecuteNonQuery();
        }

        public void Exluir(int id) // para alterar aqui no visual e passar para o Mysql
        {
            MySqlCommand cmd = Banco.AbrirConexao();
            cmd.CommandText = "DELETE FROM tb_produtosEmpresas where id_produto = " + id;
            cmd.ExecuteNonQuery();
        }
    }
}
