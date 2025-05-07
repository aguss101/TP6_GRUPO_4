using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using TP6_GRUPO_4.Conexion;

namespace TP6_GRUPO_4
{
    public class GestionProductos

    {
        NeptunoBaseAccess neptuno = new NeptunoBaseAccess();
        public GestionProductos() { /* CONSTRUCTOR VACÍO*/ }

        private DataTable RecibirTabla(string nombreTabla, string consulta)
        {
            DataSet dataset = new DataSet();
            
            SqlDataAdapter adapter = neptuno.RecibirAdapter(consulta);
            adapter.Fill(dataset, nombreTabla);
            return dataset.Tables[nombreTabla];
        }
        public DataTable RecibirProductos()
        {
            return RecibirTabla("Productos", "SELECT * FROM Productos");
        }
        private void ParametersToDelete(ref SqlCommand Comando, Producto producto)
        {
            SqlParameter parameters = new SqlParameter();
            parameters = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
          ///  SqlParametros.Value = producto.Idproducto; AÑADIR
        }
        private void ParametersToInsert(ref SqlCommand Comando, Producto producto)
        { /// MODIFICAR CHECKEANDO BASE DE DATOS
            /*
            SqlParameter parameters = new SqlParameter();
            parameters = Comando.parameters.Add("@IdProducto", SqlDbType.Int);
            parameters.Value = producto.Idproducto;
            parameters = Comando.parameters.Add("@NombreProducto", SqlDbType.VarChar);
            parameters.Value = producto.NombreProducto;
            parameters = Comando.parameters.Add("@PrecioUnitario", SqlDbType.Decimal);
            parameters.Value = producto.PrecioUnitario;
            */
        }
        public bool UpdateProduct(Producto producto)
        {
            SqlCommand cmd = new SqlCommand();
            ParametersToInsert(ref cmd, producto);
            
            int FilasInsertadas = neptuno.EjecutarProcedimientoAlmacenado(cmd, /*"spModificarProducto"*/"Categorías");
            if (FilasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteProduct(Producto producto)
        {
            SqlCommand cmd = new SqlCommand();
            ParametersToDelete(ref cmd, producto);
           
            int FilasInsertadas = neptuno.EjecutarProcedimientoAlmacenado(cmd, /*"spEliminarProducto"*/"Categorías");
            if (FilasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}