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
        private string categoria;


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Link { get => link; set => link = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Categoria { get => categoria; set => categoria = value; }


        public Item(string nome, string imagem, string valor, string link, string marca, string categoria)
        {
            this.nome = nome;
            this.imagem = imagem;
            this.valor = valor;
            this.link = link;
            this.marca = marca;
            this.categoria = categoria;
        }

        public Item()
        {

        }

        public Item(int id, string nome, string imagem, string valor, string link, string marca, string categoria, int idEmpresa = 0)
        {
            this.id = id;
            this.nome = nome;
            this.imagem = imagem;
            this.valor = valor;
            this.link = link;
            this.marca = marca;
            this.categoria = categoria;
            this.idEmpresa = idEmpresa;
        }


        public void Inserir(Item item)
        {

            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "insert into tb_produtosempresas(id_produto, nome_produto, valor_produto, link_produto, imagem_produto, marca_produto, categoria_produto, id_empresa) values(null, @nome_produto, @valor_produto, @link_produto, @imagem_produto, @marca_produto, @categoria_produto," + Program.idLogado.Id + ");";
            cmd.Parameters.Add("@nome_produto", MySqlDbType.VarChar).Value = item.Nome;
            cmd.Parameters.Add("@valor_produto", MySqlDbType.VarChar).Value = item.imagem;
            cmd.Parameters.Add("@link_produto", MySqlDbType.VarChar).Value = item.valor;
            cmd.Parameters.Add("@imagem_produto", MySqlDbType.VarChar).Value = item.valor;
            cmd.Parameters.Add("@marca_produto", MySqlDbType.VarChar).Value = item.marca;
            cmd.Parameters.Add("@categoria_produto", MySqlDbType.VarChar).Value = item.categoria;
            cmd.ExecuteNonQuery();
            

        }

        public void BuscarPorId(string nome)
        {
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_produtosempresas where nome_produto = " + nome;
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
                categoria = dr.GetString(7);

            }

        }

        public List<Item> BuscarTodos()
        {
            List<Item> item = new List<Item>();
            var cmd = Banco.AbrirConexao();
            cmd.CommandText = "select * from tb_produtosempresas where id_empresa =" + Program.idLogado.Id;
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
                        dr.GetString(6),
                        dr.GetInt32(7)
                        ));
            }
            return item;
        }

        public void Alterar(Item item) // para alterar aqui no visual e passar para o Mysql
        {
            MySqlCommand cmd = Banco.AbrirConexao();
            cmd.CommandText = "update tb_produtosempresas set nome_produto = @nome_produto ,  valor_produto = @valor_produto, link_produto = @link_produto, imagem_produto = @imagem_produto, marca_produto = @marca_produto where id_produto = @id ;";
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
            cmd.CommandText = "DELETE FROM tb_produtosempresas where id_produto = " + id;
            cmd.ExecuteNonQuery();
        }
    }
}
