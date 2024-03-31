using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace evaluation_form
{
    internal class BD
    {
        public static string data_source = "datasource=localhost;username=root;password=;database=evaluation-form";


        public static MySqlConnection ConectarBD()
        {
            MySqlConnection conexao = new MySqlConnection(data_source);
            try
            {
                conexao.Open();
                return conexao;
            }
            catch
            {
                conexao.Dispose();
                return null;
            }
        }
    }
}
