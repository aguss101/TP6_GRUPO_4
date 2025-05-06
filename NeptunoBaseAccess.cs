using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP6_GRUPO_4
{
    public class NeptunoBaseAccess
    {
        private const string LinkConexion = @"Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public void Conexion(string QuerySQL)
        { 

            SqlConnection Conect = new SqlConnection(LinkConexion);
            Conect.Open();
            SqlCommand cmd = new SqlCommand(QuerySQL, Conect);

            Conect.Close();
        }
    }
}