using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppPresentei_
{
    public static class Banco
    {
        public static string StrCon = @"server=localhost;user id=root;database=presentei;password=";

        public static MySqlCommand AbrirConexao()
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection cn = new MySqlConnection(StrCon);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception)
            {



            }

            return cmd;
        }
    }
}
