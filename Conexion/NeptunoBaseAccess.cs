using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace TP6_GRUPO_4
{
    public class NeptunoBaseAccess
    {
        string LinkConexion = @"Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public NeptunoBaseAccess()
        {
            // Constructor
        }

        public SqlConnection RecibirConexion()
        {
            SqlConnection conect = new SqlConnection(LinkConexion);
            try
            {
                conect.Open();
                return conect;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public SqlDataAdapter RecibirAdapter(string consulta)
        {
            SqlDataAdapter adapter;
            try
            {
            adapter = new SqlDataAdapter(consulta, RecibirConexion());
            return adapter;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int EjecutarProcedimientoAlmacenado(SqlCommand cmdSQL, string nameProcedure)
        {
            int FilasCambiadas;
            SqlConnection conect = RecibirConexion();
            SqlCommand cmdPA = new SqlCommand();
            cmdPA = cmdSQL;
            cmdPA.Connection = conect;
            cmdPA.CommandType = CommandType.StoredProcedure;    /// TIPO DE COMANDO (PROCEDIMIENTO ALMACENADO -- "PROCEDURE")
            cmdPA.CommandText = nameProcedure;                  /// NOMBRE DEL PROCEDIMIENTO ALMACENADO
            FilasCambiadas = cmdPA.ExecuteNonQuery();          /// EJECUTAR PROCEDIMIENTO ALMACENADO
            conect.Close();
            return FilasCambiadas;
        }
    }
}