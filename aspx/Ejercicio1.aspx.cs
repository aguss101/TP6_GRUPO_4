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
       
        private NeptunoBaseAccess neptunoBaseAccess = new NeptunoBaseAccess();
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
            gestionProductos.RecibirProductos();
            GridView1.DataSource = gestionProductos;
            GridView1.DataBind();
        }
}
    }
