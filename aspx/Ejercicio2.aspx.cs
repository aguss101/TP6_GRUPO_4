using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_4
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        
        new GestionProductos gestionProductos = new GestionProductos();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lbEliminarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            getProductos();
            lbldelete.Text = "Los productos seleccionados fueron eliminados";
        }


        protected void getProductos()
        {
            DataTable productos = gestionProductos.RecibirProductos();
            List<string> seleccionados = Session["Seleccionados"] as List<string>;
            Session["Seleccionados"] = null;

        }
    }
}