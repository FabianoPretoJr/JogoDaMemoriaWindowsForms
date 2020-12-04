using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JogoDaMemoria
{
    class PlacarDAL
    { 
        Conexao con = new Conexao();

        public void Cadastrar(Placar p)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"INSERT INTO Placar(Nome, score) VALUES (@nome, @score)";
            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@score", p.Score);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Nome, Score FROM Placar";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
    }
}