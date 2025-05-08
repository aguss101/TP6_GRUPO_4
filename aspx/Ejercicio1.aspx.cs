using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_4.Conexion;


namespace TP6_GRUPO_4
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
       
      
                GestionProductos gestionProductos = new GestionProductos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getProductos();
            }
        }
    public void getProductos()
        {
          
           
            gvProductos.DataSource = gestionProductos.RecibirProductos();
            gvProductos.DataBind();
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            getProductos();
        }

        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            getProductos();
        }

        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1;
            getProductos();
        }

        protected void gvProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            
        }

        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_IdProducto")).Text;
            string nombreProducto = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txb_eit_NombreProducto")).Text;
            string cantidadPorUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txb_eit_CantidadPorUnidad")).Text;
            string precioUnitario = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txb_eit_PrecioUnidad")).Text;
            Producto producto = new Producto(
                    Convert.ToInt32(idProducto), nombreProducto,cantidadPorUnidad, Convert.ToDecimal(precioUnitario));




            if (gestionProductos.UpdateProduct(producto))
            {
                lblMessage.Text = "Producto actualizado correctamente.";
                gvProductos.EditIndex = -1;
                getProductos();
            }
            else
            {
                lblMessage.Text = "Error al actualizar el producto.";
            }
        }
    }
    }
