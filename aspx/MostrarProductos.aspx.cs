using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_4.Conexion;

namespace TP6_GRUPO_4.aspx
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        GestionProductos gestionProductos = new GestionProductos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getProductos();
            }
        }
        protected void getProductos()
        {
            DataTable productos = gestionProductos.RecibirProductos();
            List<string> seleccionados = Session["Seleccionados"] as List<string>;

            if(seleccionados == null || seleccionados.Count == 0)
            {
                gvProductos.DataSource = null;
                gvProductos.DataBind();
            }
            else
            {
                DataTable filtrado = productos.Clone();
                foreach (DataRow row in productos.Rows)
                {
                    string id = row["IdProducto"].ToString();
                    if (seleccionados.Contains(id))
                    {
                        filtrado.ImportRow(row);
                    }
                }
                gvProductos.DataSource = filtrado;
                gvProductos.DataBind();
            }
        }
        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            getProductos();
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}