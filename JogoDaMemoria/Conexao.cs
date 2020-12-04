using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JogoDaMemoria
{
    public class Conexao
    {
        SqlConnection con;
        public Conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=FABIANO;
                                     Initial Catalog=JogoMemoria;
                                     Integrated security=true";
        }

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}