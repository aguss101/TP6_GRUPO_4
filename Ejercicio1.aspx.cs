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
        private const string LinkConexion = @"Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private string QuerySQL = "SELECT * FROM Clientes";
        private NeptunoBaseAccess neptunoBaseAccess = new NeptunoBaseAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}