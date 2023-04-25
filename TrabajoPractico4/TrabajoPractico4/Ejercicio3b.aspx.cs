using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient; 

namespace TrabajoPractico4
{
    public partial class Ejercicio3b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {               
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Libros", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                grvListadoDeLibros.DataSource = dr;
                grvListadoDeLibros.DataBind();
            }
        }

        
    }
}