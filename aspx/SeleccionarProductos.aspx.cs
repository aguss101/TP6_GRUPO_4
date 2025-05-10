using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_4.Conexion;

namespace TP6_GRUPO_4.aspx
{
    public partial class SeleccionarProductos : System.Web.UI.Page
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
    }
    
}