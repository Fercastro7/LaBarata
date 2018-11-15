using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace La_Barata
{
    class conection
    {

        public static MySqlConnection Conexion()
        {
            MySqlConnectionStringBuilder con = new MySqlConnectionStringBuilder();
            con.Server = "localhost";
            con.UserID = "root";
            con.Password = "fer1997xd";
            con.Database = "la_barata";
            con.SslMode = MySqlSslMode.None;
            MySqlConnection ConxB = new MySqlConnection(con.ToString());
            ConxB.Open();

            return ConxB;
        }

    }
}
