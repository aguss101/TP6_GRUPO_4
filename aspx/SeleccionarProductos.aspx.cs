using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_4.Conexion;

namespace TP6_GRUPO_4.aspx
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        GestionProductos gestionProductos = new GestionProductos();
        private List<string> ProductosSeleccionados
        {
            get
            {
                if (Session["Seleccionados"] == null) Session["Seleccionados"] = new List<string>();
                return (List<string>)Session["Seleccionados"];
            }
            set
            {
                Session["Seleccionados"] = value;
            }
        }
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
        protected void ToggleSeleccion(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ToggleSeleccion")
            {
                string idProducto = e.CommandArgument.ToString();

                List<string> seleccionados = ProductosSeleccionados;

                if (seleccionados.Contains(idProducto)) seleccionados.Remove(idProducto);
                else seleccionados.Add(idProducto);

                ProductosSeleccionados = seleccionados;
            }
            getProductos();
            gvProductos.DataBind();
        }
        protected string ToggleName(object idProducto)
        {
            string id = idProducto.ToString();
            List<string> seleccionados = ProductosSeleccionados;
            return seleccionados.Contains(id) ? "Deseleccionar" : "Seleccionar";
        }
    }
    
}