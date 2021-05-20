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
        public static string StrCon = @"server=softkleen.com.br;user id=alunos_presentei;database=wellington_presentei;password=f5ex0!7T";

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
