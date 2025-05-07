using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        protected void gestionarProducto(object sender, CommandEventArgs e)
        {
            if(sender is LinkButton lb)
            {
                string idProducto = e.CommandArgument.ToString();

                if (e.CommandName == "UpdateProduct")
                {
                    Response.Write("Guardar producto con ID: " + idProducto);
                    lb.Text = "Edit";
                    lb.CommandName = "EditProduct";

                }
                else if (e.CommandName == "EditProduct")
                {
                    Response.Write("Editar producto con ID: " + idProducto);
                    lb.Text = "Update";
                    lb.CommandName = "UpdateProduct";

                }
                else if (e.CommandName == "DeleteProduct")
                {
                    Response.Write("Borrar producto con ID: " + idProducto);
                }
            }
        }
    }
}
